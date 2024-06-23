using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.models
{
    public class Obat
    {
        public int idObat { get; set; }
        public string nama { get; set; }
        public string jenis { get; set; }

        public Obat(int idObat, string nama, string jenis)
        {
            this.idObat = idObat;
            this.nama = nama;
            this.jenis = jenis;
        }
    }
}
