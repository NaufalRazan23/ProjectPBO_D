using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.models
{
    public class Jadwal
    {
        public int idJadwal {  get; set; }
        public string hari {  get; set; }
        public TimeOnly jamSelesai;
        public TimeOnly jamMulai;
        public Dokter dokter;

        public Jadwal(int idJadwal, string hari, TimeOnly jamSelesai, TimeOnly jamMulai, Dokter dokter)
        {
            this.idJadwal = idJadwal;
            this.hari = hari;
            this.jamSelesai = jamSelesai;
            this.jamMulai = jamMulai;
            this.dokter = dokter;
        }
    }
}
