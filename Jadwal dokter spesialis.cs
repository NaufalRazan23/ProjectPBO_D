using ProjectPBO.controllers;
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
    public partial class Jadwal_dokter_spesialis : Form
    {
        JadwalController jadwalController;
        public Jadwal_dokter_spesialis()
        {
            InitializeComponent();
            jadwalController = new JadwalController();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            this.CHari.DataPropertyName = "hari";
            this.CMulai.DataPropertyName = "jamMulai";
            this.CSelesai.DataPropertyName = "jamSelesai";
            this.CDokter.DataPropertyName = "DisplayNama";
            this.CJenis.DataPropertyName = "DisplayJenis";
            this.dataGridView1.DataSource = jadwalController.listJadwal;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
