using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.models
{
    public class Dokter
    {
        public int idDokter;
        public string nama;
        public string email;
        public string jenisDokter;

        public Dokter(int idDokter, string nama, string email, string jenisDokter)
        {
            this.idDokter = idDokter;
            this.nama = nama;
            this.email = email;
            this.jenisDokter = jenisDokter;
        }
    }
    
}
