using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.Data
{
    public class DoktorSpesialis
    {
        public DoktorSpesialis(string dokter, string spesialis, string hari, string jam)
        {
            Dokter = dokter;
            Spesialis = spesialis;
            Hari = hari;
            Jam = jam;
        }
        public string Hari { get; set; }
        public string Spesialis { get; set; }
        public string Dokter { get; set; }
        public string Jam { get; set; }
    }
}
