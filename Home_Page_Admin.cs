﻿using System;
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
    public partial class Home_Page_Admin : Form
    {
        public Home_Page_Admin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            EditJadwalDokter editJadwalDokter = new EditJadwalDokter();
            editJadwalDokter.FormClosed += (s, args) => this.Show();
            editJadwalDokter.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Tampilan_nomor_antrian tampilan_Nomor_Antrian = new Tampilan_nomor_antrian();
            tampilan_Nomor_Antrian.FormClosed += (s, args) => this.Show();
            tampilan_Nomor_Antrian.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditJadwalDokter editJadwalDokter = new EditJadwalDokter();
            editJadwalDokter.FormClosed += (s, args) => this.Show();
            editJadwalDokter.Show();
            this.Hide();
        }
    }
}
