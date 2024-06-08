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
    public partial class Tampilan_nomor_antrian : Form
    {
        List<Antrian?> antrianSekarang;
        AdminAntrianController adminAntrianController;
        List<List<string>> listLabel;
        List<Label> lblNomorAntrian;
        List<Label> lblJenisDokter;
        List<Label> lblKeterangan;
        Dictionary<string, int> labelKeIndex = new Dictionary<string, int>();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private Home_Page_Admin Home_Page_AdminInstance;

        public Tampilan_nomor_antrian(Home_Page_Admin Home_Page_AdminInstance)
        {
            InitializeComponent();

            adminAntrianController = new AdminAntrianController();
            antrianSekarang = [null, null, null, null, null, null, null, null, null, null, null, null];
            lblNomorAntrian = new List<Label> { lblNomorAntrian1, lblNomorAntrian2, lblNomorAntrian3, lblNomorAntrian4, lblNomorAntrian5, lblNomorAntrian6, lblNomorAntrian7, lblNomorAntrian8, lblNomorAntrian9 };
            lblJenisDokter = new List<Label> { lblJenisDokter1, lblJenisDokter2, lblJenisDokter3, lblJenisDokter4, lblJenisDokter5, lblJenisDokter6, lblJenisDokter7, lblJenisDokter8, lblJenisDokter9 };
            lblKeterangan = new List<Label> { lblKeterangan1, lblKeterangan2, lblKeterangan3, lblKeterangan4, lblKeterangan5, lblKeterangan6, lblKeterangan7, lblKeterangan8, lblKeterangan9 };
            //btnTandaiMasuk = new List<Button> { btnTandaiMasuk1, btnTandaiMasuk2, btnTandaiMasuk3, btnTandaiMasuk4, btnTandaiMasuk5, btnTandaiMasuk6, btnTandaiMasuk7, btnTandaiMasuk8, btnTandaiMasuk9 };
            adminAntrianController = new AdminAntrianController();

            listLabel = adminAntrianController.getLabel();
            for (int index = 0; index < listLabel.Count; index++)
            {
                labelKeIndex.Add(listLabel[index][0], index);
                lblJenisDokter[index].Text = listLabel[index][1];
            }

            RefreshAntrian();
            timer.Tick += (s, args) => RefreshAntrian();
            timer.Interval = 3000;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            RefreshAntrian();
        }

        private void RefreshAntrian()
        {
            adminAntrianController.listAntrian = adminAntrianController.getAntrian();
            foreach (var item in listLabel)
            {
                Antrian? antrianSekarangDiLabelIni = adminAntrianController.getAntrianSekarang(item[0]);
                if (antrianSekarangDiLabelIni != null)
                {
                    int index = labelKeIndex[antrianSekarangDiLabelIni.labelAntrian];
                    this.antrianSekarang[index] = antrianSekarangDiLabelIni;
                    var pad = antrianSekarangDiLabelIni.nomorAntrian.ToString("000");
                    string nomorBaru = $"{antrianSekarangDiLabelIni.labelAntrian}   {pad[0]}   {pad[1]}   {pad[2]}";
                    if (lblNomorAntrian[index].Text != nomorBaru && this.Visible)
                    {
                        popupSelesai dialogAntrianSelesai = new popupSelesai(lblNomorAntrian[index].Text, nomorBaru, antrianSekarangDiLabelIni.atasNama);
                        dialogAntrianSelesai.Show();
                    }
                    lblNomorAntrian[index].Text = nomorBaru;
                    lblKeterangan[index].Text = $"Atas Nama: {antrianSekarangDiLabelIni.atasNama}\nStatus: {antrianSekarangDiLabelIni.statusAntrian}";
                }
                else
                {
                    int index = labelKeIndex[item[0]];
                    this.antrianSekarang[index] = antrianSekarangDiLabelIni;
                    lblNomorAntrian[index].Text = $"{item[0]}   0   0   0";
                    lblKeterangan[index].Text = $"Atas Nama: -\nStatus: -";
                }
            }
        }

        private void diklik(int index)
        {
            if (this.antrianSekarang[index] != null)
            {
                adminAntrianController.tandaiMasuk(this.antrianSekarang[index]);
            }
            this.RefreshAntrian();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Tampilan_nomor_antrian_Load(object sender, EventArgs e)
        {

        }

        private void Tampilan_nomor_antrian_FormClosed(object sender, FormClosedEventArgs e)
        {
            Home_Page_Admin home_Page_Admin = new Home_Page_Admin();
            home_Page_Admin.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_kembali(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnTandaiMasuk1_Click(object sender, EventArgs e) { this.diklik(0); }

        private void panel42_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTandaiMasuk2_Click(object sender, EventArgs e) { this.diklik(1); }

        private void btnTandaiMasuk3_Click(object sender, EventArgs e) { this.diklik(2); }

        private void btnTandaiMasuk4_Click(object sender, EventArgs e) { this.diklik(3); }


        private void btnTandaiMasuk5_Click(object sender, EventArgs e) { this.diklik(4); }

        private void btnTandaiMasuk6_Click(object sender, EventArgs e) { this.diklik(5); }

        private void btnTandaiMasuk7_Click(object sender, EventArgs e) { this.diklik(6); }

        private void btnTandaiMasuk8_Click(object sender, EventArgs e) { this.diklik(7); }

        private void btnTandaiMasuk9_Click(object sender, EventArgs e) { this.diklik(8); }


        private void AdminAntrianAllView_Load(object sender, EventArgs e)
        {

        }

        private void lblJenisDokter1_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TampilanAntrianUntukDokter adminAntrianOne = new TampilanAntrianUntukDokter();
            adminAntrianOne.FormClosed += (s, args) => this.Show();
            adminAntrianOne.Show();
        }

        private void panel47_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
