using Npgsql;
using ProjectPBO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.controllers
{
    public class AdminJadwalController
    {
        private EditJadwalDoktor? view;
        public List<Jadwal> listJadwal;

        public AdminJadwalController()
        {
            this.listJadwal = this.getListJadwal();
        }

        public List<Jadwal> getListJadwal() {
            List<Jadwal> listJadwal = new List<Jadwal>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = @"select jd.id_jadwal, jd.hari, jd.jam_mulai, jd.jam_selesai,
            d.id_dokter, d.nama_dokter, d.email_dokter, jed.nama_jenis_dokter
            from jadwal_dokter jd
            join dokter d on (jd.id_jadwal = d.id_jadwal)
            join jenis_dokter jed on (jed.id_jenis_dokter = d.id_jenis_dokter)";
            NpgsqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                int idJadwal = reader.GetInt32(0);
                string hari = reader.GetString(1);
                TimeOnly mulai = TimeOnly.FromTimeSpan(reader.GetTimeSpan(2));
                TimeOnly selesai = TimeOnly.FromTimeSpan(reader.GetTimeSpan(3));
                int idDokter = reader.GetInt32(4);
                string nama = reader.GetString(5);
                string email = reader.GetString(6);
                string jenis = reader.GetString(7);

                Dokter dokter = new Dokter(idDokter, nama, email, jenis);
                Jadwal jadwal = new Jadwal(idJadwal, hari, selesai, mulai, dokter);
                listJadwal.Add(jadwal);
            }
            koneksi.Close();
            return listJadwal;
        }
    }
}
