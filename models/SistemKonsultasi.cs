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

        public List<(Penyakit, float)> getHasilPrediksi()
        {
            var hasilPrediksi = new List<(Penyakit, float)>();
            // Belum jadi
            hasilPrediksi.Add((daftarPenyakit[0], 0.98F));
            hasilPrediksi.Add((daftarPenyakit[1], 0.451F));
            return hasilPrediksi;
        }
    }
}
