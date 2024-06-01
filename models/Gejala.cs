using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.models
{
    public class Gejala
    {
        public int idGejala { get; set; }
        public string nama {  get; set; }

        public Gejala(int idGejala, string nama)
        {
            this.idGejala = idGejala;
            this.nama = nama;
        }
    }
}
