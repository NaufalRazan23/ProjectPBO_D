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
        public Tampilan_nomor_antrian()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Tampilan_nomor_antrian_FormClosed);
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
        private Home_Page_Admin Home_Page_AdminInstance;

        // Konstruktor untuk form nomor antrian dengan parameter instance form admin
        public Tampilan_nomor_antrian(Home_Page_Admin Home_Page_AdminInstance)
        {
            InitializeComponent();
            this.Home_Page_AdminInstance = Home_Page_AdminInstance;
        }

        private void label46_Click(object sender, EventArgs e)
        {
            TampilanAntrianUntukDokter tampildkt = new TampilanAntrianUntukDokter();
            tampildkt.FormClosed += (s, args) => this.Show();
            tampildkt.Show();
            this.Hide();
        }
    }
}
