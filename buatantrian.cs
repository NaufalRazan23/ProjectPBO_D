using ProjectPBO.controllers;
using ProjectPBO.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPBO
{
    public partial class buatantrian : Form
    {
        PublikAntrianController publikAntrianController;
        string label;
        string atasNama;
        public buatantrian()
        {
            InitializeComponent();
            publikAntrianController = new PublikAntrianController();
            List<Tuple<string, string>> comboBoxItems = [new Tuple<string, string>("-", "Pilih Dokter")];
            foreach (var item in publikAntrianController.label)
            {
                comboBoxItems.Add(new Tuple<string, string>(item[0], item[1]));
            }
            guna2ComboBox1.DataSource = comboBoxItems;
            guna2ComboBox1.DisplayMember = "Item2";
            guna2ComboBox1.SelectedIndex = 0;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (label == "-") { return; }
            atasNama = IniNamaLengkap.Text;
            Antrian? antrianBaru = publikAntrianController.addAntrian(atasNama, label);
            if (antrianBaru == null)
            {
                MINIgagalantri mINIgagalantri = new MINIgagalantri();
                mINIgagalantri.ShowDialog();
                return;
            }
            berhasilDibuat berhasildibuat = new berhasilDibuat(atasNama, $"{antrianBaru.labelAntrian}{antrianBaru.nomorAntrian.ToString("000")}");
            berhasildibuat.ShowDialog();
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            Jadwal_dokter_spesialis jadwalDokterSpesialisForm = new Jadwal_dokter_spesialis();

            jadwalDokterSpesialisForm.Show();

            this.Hide();

            jadwalDokterSpesialisForm.FormClosed += (s, args) => this.Close();

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (Tuple<string, string>)guna2ComboBox1.SelectedItem;
            label = selectedItem.Item1;
            var antrianSekarang = publikAntrianController.getAntrianSekarang(label);
            ButUmum.Text = selectedItem.Item2;
            if (antrianSekarang == null)
            {
                lblSaatIni.Text = $"{label}   -   -   -";
            }
            else
            {
                var pad = antrianSekarang.nomorAntrian.ToString("000");
                lblSaatIni.Text = $"{label}   {pad[0]}   {pad[1]}   {pad[2]}";
            }
        }

        private void buatantrian_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IniNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Jadwal_dokter_spesialis jadwal_dokter_spesialis = new Jadwal_dokter_spesialis();
            jadwal_dokter_spesialis.FormClosed += (s, args) => this.Show();
            jadwal_dokter_spesialis.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
