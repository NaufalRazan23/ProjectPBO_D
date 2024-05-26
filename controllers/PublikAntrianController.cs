using Npgsql;
using ProjectPBO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.controllers
{
    public class PublikAntrianController
    {
        // Sementara
        // private ???? view;
        public List<Antrian> listAntrian = new List<Antrian>();
        public List<List<string>> label = []; // [["A", "Dokter Poli Umum"], ["B", "Dokter Spesialis Gigi Mulut"], dst.]

        public PublikAntrianController()
        {
            this.listAntrian = this.getAntrian();
            this.label = this.getLabel();
        }

        public List<Antrian> getAntrian()
        {
            List<Antrian> listAntrian = new List<Antrian>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = @"select a.id_antrian, a.nomor_antrian, a.atas_nama, s.keterangan_status, j.label,
            d.id_dokter, d.nama_dokter, d.email_dokter, j.nama_jenis_dokter
            from antrian_pengunjung a
            join status_pengunjung s on (a.id_status = s.id_status)
            join dokter d on (d.id_dokter = a.id_dokter)
            join jenis_dokter j on (j.id_jenis_dokter = d.id_jenis_dokter)
            where a.tanggal = date (now())
            order by j.label, a.nomor_antrian";
            NpgsqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                int idAntrian = reader.GetInt32(0);
                int nomorAntrian = reader.GetInt32(1);
                string atasNama = reader.GetString(2);
                string statusAntrian = reader.GetString(3);
                string labelAntrian = reader.GetString(4);

                int idDokter = reader.GetInt32(5);
                string nama = reader.GetString(6);
                string email = reader.GetString(7);
                string jenis = reader.GetString(8);

                Dokter dokter = new Dokter(idDokter, nama, email, jenis);
                Antrian antrian= new Antrian(idAntrian, nomorAntrian, atasNama, statusAntrian, labelAntrian, dokter);
                listAntrian.Add(antrian);
            }
            koneksi.Close();
            return listAntrian;
        }

        public Antrian? getAntrianSekarang(string label)
        {
            Antrian? antrianSekarang = null;
            foreach (Antrian antrian in listAntrian)
            {
                if (antrian.labelAntrian != label || antrian.statusAntrian == "sudah selesai")
                {
                    continue;
                } else
                {
                    antrianSekarang = antrian;
                    break;
                }
            }
            return antrianSekarang;
        }

        public List<List<string>> getLabel()
        {
            List<List<string>> labels = new List<List<string>>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = @"select label, nama_jenis_dokter from jenis_dokter";
            NpgsqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                string label = reader.GetString(0);
                string nama = reader.GetString(1);
                labels.Add([label, nama]);
            }
            koneksi.Close();
            return labels;
        }

        public List<Dokter> getDokterYangSedangBekerja(string label)
        {
            var culture = new System.Globalization.CultureInfo("id-ID");
            var day = culture.DateTimeFormat.GetDayName(DateTime.Today.DayOfWeek);
            List<Dokter> listDokter = new List<Dokter>();
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = $@"select d.id_dokter, d.nama_dokter, d.email_dokter, jen.nama_jenis_dokter from jenis_dokter jen
            join dokter d on (d.id_jenis_dokter = jen.id_jenis_dokter)
            join jadwal_dokter jad on (jad.id_jadwal = d.id_jadwal)
            where
                jen.label = '{label}'
	            and now()::time between jad.jam_mulai and jad.jam_selesai
                and jad.hari = '{day}'
	            and d.status = '1'";
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

        public Antrian? addAntrian(string atasNama, string label)
        {
            Antrian? antrian = null;
            List<Dokter> dokter = this.getDokterYangSedangBekerja(label);
            if (dokter.Count == 0)
            {
                return antrian;
            }
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = @$"insert into antrian_pengunjung (nomor_antrian, atas_nama, id_dokter, tanggal, id_status)
            values (
                COALESCE(
                    (
                        SELECT MAX(nomor_antrian) FROM antrian_pengunjung
                        WHERE id_dokter = {dokter[0].idDokter} and tanggal = now()::date
                    ), 0
                ) + 1,
                @atasNama, @idDokter, now()::date, 1
            ) RETURNING id_antrian, nomor_antrian";
            query.Parameters.AddWithValue("atasNama", atasNama);
            query.Parameters.AddWithValue("idDokter", dokter[0].idDokter);
            NpgsqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                int idAntrian = reader.GetInt32(0);
                int nomorAntrian = reader.GetInt32(1);
                antrian = new Antrian(idAntrian, nomorAntrian, atasNama, "belum masuk", label, dokter[0]);
            }
            return antrian;
        }
    }
}
