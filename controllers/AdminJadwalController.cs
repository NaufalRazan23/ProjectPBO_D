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
        // Sementara
        // private EditJadwalDoktor? view;
        public List<Jadwal> listJadwal;

        public AdminJadwalController()
        {
            this.listJadwal = this.getListJadwal();
        }

        public List<Jadwal> getListJadwal()
        {
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

        public Boolean update(List<Jadwal> listJadwal)
        {
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlTransaction transaksi = koneksi.BeginTransaction();
            foreach (Jadwal jadwal in listJadwal)
            {
                NpgsqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE jadwal_dokter SET hari = @hari, jam_mulai = @mulai, jam_selesai = @selesai WHERE id_jadwal = @id";
                cmd.Parameters.AddWithValue("hari", jadwal.hari);
                cmd.Parameters.AddWithValue("mulai", jadwal.jamMulai);
                cmd.Parameters.AddWithValue("selesai", jadwal.jamSelesai);
                cmd.Parameters.AddWithValue("id", jadwal.idJadwal);
                cmd.Transaction = transaksi;
                cmd.ExecuteNonQuery();
            }
            transaksi.Commit();
            koneksi.Close();
            return true;
        }
    }
}
