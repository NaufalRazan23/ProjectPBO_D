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
    }
}
