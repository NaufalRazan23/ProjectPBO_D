using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.models
{
    public class Penyakit
    {
        public int idPenyakit;
        public string nama;
        public List<Gejala> listGejala;
        public List<Obat> listObat;

        public Penyakit(int idPenyakit, string nama, List<Gejala> listGejala, List<Obat> listObat)
        {
            this.idPenyakit = idPenyakit;
            this.nama = nama;
            this.listGejala = listGejala;
            this.listObat = listObat;
        }
    }
}
