using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectPBO.models;

namespace ProjectPBO.controllers
{
    public class JadwalController
    {
        public List<Jadwal> listJadwal;
        public enum Hari
        {
            Minggu = 0,
            Senin = 1,
            Selasa = 2,
            Rabu = 3,
            Kamis = 4,
            Jumat = 5,
            Sabtu = 6
        }

        public JadwalController()
        {
            this.listJadwal = this.getListJadwal();
        }

        // Method untuk mendapatkan semua dokter dari database
        public List<Dokter> getListDokter()
        {
            List<Dokter> listDokter = new List<Dokter>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = @"select d.id_dokter, d.nama_dokter, d.email_dokter, jed.nama_jenis_dokter from dokter d
                join jenis_dokter jed on (jed.id_jenis_dokter = d.id_jenis_dokter)";
            NpgsqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                int idDokter = reader.GetInt32(0);
                string nama = reader.GetString(1);
                string email = reader.GetString(2);
                string jenis = reader.GetString(3);

                Dokter dokter = new Dokter(idDokter, nama, email, jenis);
                listDokter.Add(dokter);
            }
            koneksi.Close();
            return listDokter;
        }

        // Method untuk mendapatkan semua jadwal beserta dokternya
        // dari database
        public List<Jadwal> getListJadwal()
        {
            List<Jadwal> listJadwal = new List<Jadwal>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = @"select jd.id_jadwal, jd.hari, jd.jam_mulai, jd.jam_selesai,
                d.id_dokter, d.nama_dokter, d.email_dokter, jed.nama_jenis_dokter
                from jadwal_dokter jd
                join dokter d on (jd.id_dokter = d.id_dokter)
                join jenis_dokter jed on (jed.id_jenis_dokter = d.id_jenis_dokter)
                order by jd.hari, jd.jam_mulai, jd.jam_selesai";
            NpgsqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                int idJadwal = reader.GetInt32(0);
                int hari = reader.GetInt32(1);
                TimeOnly mulai = TimeOnly.FromTimeSpan(reader.GetTimeSpan(2));
                TimeOnly selesai = TimeOnly.FromTimeSpan(reader.GetTimeSpan(3));
                int idDokter = reader.GetInt32(4);
                string nama = reader.GetString(5);
                string email = reader.GetString(6);
                string jenis = reader.GetString(7);

                Dokter dokter = new Dokter(idDokter, nama, email, jenis);
                Jadwal jadwal = new Jadwal(idJadwal, IntegerKeHari(hari), selesai, mulai, dokter);
                listJadwal.Add(jadwal);
            }
            koneksi.Close();
            return listJadwal;
        }

        // Method untuk mengedit jadwal di database (query UPDATE)
        public Boolean edit(Jadwal jadwal)
        {
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = @"UPDATE jadwal_dokter
                SET hari = @hari, jam_mulai = @mulai, jam_selesai = @selesai, id_dokter = @id_dokter
                WHERE id_jadwal = @id";
            cmd.Parameters.AddWithValue("hari", HariKeInteger(jadwal.hari));
            cmd.Parameters.AddWithValue("mulai", jadwal.jamMulai);
            cmd.Parameters.AddWithValue("selesai", jadwal.jamSelesai);
            cmd.Parameters.AddWithValue("id_dokter", jadwal.dokter.idDokter);
            cmd.Parameters.AddWithValue("id", jadwal.idJadwal);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            return true;
        }

        // Method untuk menghapus jadwal di database (query DELETE)
        public Boolean hapus(int id)
        {
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = @"DELETE FROM jadwal_dokter
                WHERE id_jadwal = @id";
            cmd.Parameters.AddWithValue("id", id);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            return true;
        }

        // Method untuk menambah jadwal di database (query INSERT)
        public Boolean tambah(Jadwal jadwal)
        {
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandText = @"INSERT INTO jadwal_dokter (hari, jam_mulai, jam_selesai, id_dokter) VALUES (@hari, @mulai, @selesai, @id_dokter)";
            cmd.Parameters.AddWithValue("hari", HariKeInteger(jadwal.hari));
            cmd.Parameters.AddWithValue("mulai", jadwal.jamMulai);
            cmd.Parameters.AddWithValue("selesai", jadwal.jamSelesai);
            cmd.Parameters.AddWithValue("id_dokter", jadwal.dokter.idDokter);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            return true;
        }

        // Method statis untuk mengubah hari dalam bentuk string
        // ke integer
        public static int HariKeInteger(string namaHari)
        {
            if (Enum.TryParse<Hari>(namaHari, true, out Hari hasil))
            {
                return (int)hasil;
            }
            else
            {
                throw new ArgumentException("Nama hari tidak valid.");
            }
        }

        // Method statis untuk mengubah hari dalam bentuk integer
        // ke string
        public static string IntegerKeHari(int nilai)
        {
            if (Enum.IsDefined(typeof(Hari), nilai))
            {
                return ((Hari)nilai).ToString();
            }
            else
            {
                throw new ArgumentException("Nilai integer tidak valid.");
            }
        }
    }
}
