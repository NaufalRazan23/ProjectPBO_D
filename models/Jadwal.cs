using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.models
{
    public class Jadwal
    {
        public int idJadwal { get; set; }
        public string hari { get; set; }
        public TimeOnly jamSelesai { get; set; }
        public TimeOnly jamMulai { get; set; }
        public Dokter dokter;
        public string DisplayNama => dokter?.nama;
        public int DisplayIdDokter => (int)dokter?.idDokter;
        public string DisplayJenis => dokter?.jenisDokter;

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
