using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.models
{
    public class Antrian
    {
        public int idAntrian { get; set; }
        public int nomorAntrian { get; set; }
        public string atasNama { get; set; }
        public string statusAntrian { get; set; }
        public string labelAntrian { get; set; }
        public Dokter dokter;

        public Antrian(int idAntrian, int nomorAntrian, string atasNama, string statusAntrian, string labelAntrian, Dokter dokter)
        {
            this.idAntrian = idAntrian;
            this.nomorAntrian = nomorAntrian;
            this.atasNama = atasNama;
            this.statusAntrian = statusAntrian;
            this.labelAntrian = labelAntrian;
            this.dokter = dokter;
        }   
    }
}
