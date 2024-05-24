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

        public SistemKonsultasi()
        {
            daftarGejala = new List<Gejala>();
            daftarPenyakit = new List<Penyakit>();
        }
        public void tambahGejala(Gejala gejala)
        {
            daftarGejala.Add(gejala);
        }
        /*
        public List<Penyakit> getHasilPrediksi()
        {
            var hasilPrediksi = new List<Penyakit>();
            foreach (var gejala in daftarGejala) 
            {
                if (gejala.nama.)
            }
        }
        */
    }
}
