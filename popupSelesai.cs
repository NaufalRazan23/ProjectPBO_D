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
    public partial class popupSelesai : Form
    {
        public popupSelesai(string sebelumnya, string nomor, string nama)
        {
            InitializeComponent();
            label2.Text = $"PASIEN {sebelumnya} TELAH SELESAI";
            label6.Text = nomor;
            label8.Text = nama;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
