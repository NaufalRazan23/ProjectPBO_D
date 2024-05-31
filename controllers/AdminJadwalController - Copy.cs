using Npgsql;
using ProjectPBO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO.controllers
{
    public class AdminAntrianView
    {
        public List<Antrian> listAntrian = new List<Antrian>();
        public List<List<string>> label = [];

        public AdminAntrianView()
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
                Antrian antrian = new Antrian(idAntrian, nomorAntrian, atasNama, statusAntrian, labelAntrian, dokter);
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
                }
                else
                {
                    antrianSekarang = antrian;
                    break;
                }
            }
            return antrianSekarang;
        }

        public void tandaSelesai(Antrian antrian)
        {
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = @"update antrian_pengunjung
                                  set id_status = 2
                                  where id_antrian = @idAntrian";
            query.Parameters.AddWithValue("idAntrian", antrian.idAntrian);
            query.ExecuteNonQuery();
            koneksi.Close();
            antrian.statusAntrian = "sudah selesai";
        }

        public void tandaiMasuk(Antrian antrian)
        {
            NpgsqlConnection koneksi = KoneksiDatabase.BuatKoneksi();
            koneksi.Open();
            NpgsqlCommand query = koneksi.CreateCommand();
            query.CommandText = @"update antrian_pengunjung
                                  set id_status = 1
                                  where id_antrian = @idantrian";
            query.Parameters.AddWithValue("idAntrian", antrian.idAntrian);
            query.ExecuteNonQuery();
            koneksi.Close();
            antrian.statusAntrian = "sudah masuk";
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

        
    }
}
