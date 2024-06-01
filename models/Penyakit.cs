using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.models
{
    public class Penyakit
    {
        public int idPenyakit {  get; set; }
        public string nama {  get; set; }

        public Penyakit(int idPenyakit, string nama)
        {
            this.idPenyakit = idPenyakit;
            this.nama = nama;
        }
    }
}
