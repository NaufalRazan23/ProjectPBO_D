using ProjectPBO.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPBO
{
    public partial class KonsultasiForm : BaseForm
    {
        private PublikKonsultasiController publikKonsultasiController;
        private SistemKonsultasi sistemKonsultasi;
        private List<Gejala> semuaGejala;
        public KonsultasiForm() : base()
        {
            InitializeComponent();
            sistemKonsultasi = new SistemKonsultasi();
            publikKonsultasiController = new PublikKonsultasiController(sistemKonsultasi);
            semuaGejala = publikKonsultasiController.GetListGejala();

            cbKeluhan1.DataSource = semuaGejala.Prepend(new Gejala(0, "Pilih gejala...")).ToList();
            cbKeluhan1.DisplayMember = "nama";
            cbKeluhan1.SelectedIndex = 0;
            cbKeluhan2.DataSource = semuaGejala.Prepend(new Gejala(0, "Pilih gejala...")).ToList();
            cbKeluhan2.DisplayMember = "nama";
            cbKeluhan2.SelectedIndex = 0;
            cbKeluhan3.DataSource = semuaGejala.Prepend(new Gejala(0, "Pilih gejala...")).ToList();
            cbKeluhan3.DisplayMember = "nama";
            cbKeluhan3.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sistemKonsultasi.daftarGejala = [(Gejala)cbKeluhan1.SelectedItem, (Gejala)cbKeluhan2.SelectedItem, (Gejala)cbKeluhan3.SelectedItem];
            var hasilKonsultasi = sistemKonsultasi.getHasilPrediksi();

            foreach (var a in hasilKonsultasi)
            {
                Debug.WriteLine(a.Item1.nama);
                Debug.WriteLine(a.Item2);
            }

            Penyakit penyakit1 = hasilKonsultasi[0].Item1;
            string persentase1 = $"{(int)(hasilKonsultasi[0].Item2 * 100)}%";
            Penyakit penyakit2 = hasilKonsultasi[1].Item1;
            string persentase2 = $"{(int)(hasilKonsultasi[1].Item2 * 100)}%";

            Obat obat1 = penyakit1.listObat[0];
            Obat obat2 = penyakit1.listObat[1];

            RekomendasiObatForm rekomendasiObatForm = new RekomendasiObatForm(penyakit1.nama, persentase1, penyakit2.nama, persentase2, obat1.nama, obat2.nama);
            rekomendasiObatForm.Show();
            this.Hide();
            rekomendasiObatForm.FormClosed += (s, args) => this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void KonsultasiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
