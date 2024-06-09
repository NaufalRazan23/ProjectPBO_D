using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.models
{
    public class SistemKonsultasi
    {
        public List<Gejala> daftarGejala;
        public List<Penyakit> daftarPenyakit;

        public List<(Penyakit, float)> getHasilPrediksi()
        {
            var hasilPrediksi = new List<(Penyakit, float)>();
            foreach (var penyakit in daftarPenyakit)
            {
                int cocok = 0;
                foreach (var gejala in penyakit.listGejala)
                {
                    var ada = false;
                    foreach (var i in daftarGejala)
                    {
                        if (i.idGejala == gejala.idGejala)
                        {
                            ada = true;
                            break;
                        }
                    }
                    if (ada)
                    {
                        cocok++;
                    }
                }
                hasilPrediksi.Add((penyakit, (float)cocok / penyakit.listGejala.Count));
            }
            hasilPrediksi.Sort((x, y) => y.Item2.CompareTo(x.Item2));
            return hasilPrediksi;
        }
    }
