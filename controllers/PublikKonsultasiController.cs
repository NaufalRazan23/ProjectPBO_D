using ProjectPBO.models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProjectPBO
{
    public class PublikKonsultasiController
    {
        private Form2 view;
        public SistemKonsultasi sistemKonsultasi;

        public PublikKonsultasiController(Form2 view, SistemKonsultasi sistemKonsultasi) {
            this.view = view;
            this.sistemKonsultasi = sistemKonsultasi;
            this.sistemKonsultasi.daftarPenyakit = this.GetListPenyakit();
        }

        // Metode untuk membaca semua penyakit di database
        public List<Penyakit> GetListPenyakit()
        {
            List<Penyakit> listPenyakit = new List<Penyakit>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = "SELECT * FROM prediksi_penyakit";
            NpgsqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nama = reader.GetString(1);
                Penyakit penyakit = new Penyakit(id, nama);
                listPenyakit.Add(penyakit);
            }
            koneksi.Close();
            return listPenyakit;
        }

        public List<Gejala> GetListGejala() {
            List<Gejala> listGejala = new List<Gejala>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = "SELECT * FROM gelaja";
            NpgsqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nama = reader.GetString(1);
                Gejala gejala = new Gejala(id, nama);
                listGejala.Add(gejala);
            }
            koneksi.Close();
            return listGejala;
        }

        public List<Gejala> getGejalaFromPenyakit(Penyakit penyakit)
        {
            int idPenyakit = penyakit.idPenyakit;
            List<Gejala> listGejala = new List<Gejala>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = $@"select g.id_gejala, g.gejala from detail_penyakit dp
            join gelaja g on g.id_gejala = dp.id_gejala
            where id_penyakit = {idPenyakit}";
            NpgsqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nama = reader.GetString(1);
                Gejala gejala = new Gejala(id, nama);
                listGejala.Add(gejala);
            }
            koneksi.Close();
            return listGejala;
        }

        public List<Obat> getObatFromPenyakit(Penyakit penyakit) {
            int idPenyakit = penyakit.idPenyakit;
            List<Obat> listObat = new List<Obat>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = $@"select o.id_obat, o.nama_obat, jo.jenis from obat o
            join jenis_obat jo on jo.id_jenis = o.id_jenis
            where o.id_penyakit = {idPenyakit}";
            NpgsqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string nama = reader.GetString(1);
                string jenis = reader.GetString(2);
                Obat obat = new Obat(id, nama, jenis);
                listObat.Add(obat);
            }
            koneksi.Close();
            return listObat;
        }
    }
}
