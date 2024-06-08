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
using static ProjectPBO.controllers.JadwalController;

namespace ProjectPBO
{
    public partial class MINITambahJadwal : Form
    {
        public List<Dokter> listDokter;
        public Jadwal? jadwal;
        public MINITambahJadwal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hari = (string)guna2ComboBox2.SelectedValue;
            TimeOnly jamMulai = TimeOnly.FromDateTime(dtpMulai.Value);
            TimeOnly jamSelesai = TimeOnly.FromDateTime(dtpSelesai.Value);
            int idDokter = (int)guna2ComboBox1.SelectedValue;
            this.jadwal = new Jadwal(0, hari, jamSelesai, jamMulai, new Dokter(idDokter, "", "", ""));
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void MINITambahJadwal_Load(object sender, EventArgs e)
        {
            List<Tuple<int, string>> comboBoxItems = [
                new Tuple<int, string>(0, "Minggu"),
                new Tuple<int, string>(1, "Senin"),
                new Tuple<int, string>(2, "Selasa"),
                new Tuple<int, string>(3, "Rabu"),
                new Tuple<int, string>(4, "Kamis"),
                new Tuple<int, string>(5, "Jumat"),
                new Tuple<int, string>(6, "Sabtu"),
            ];
            guna2ComboBox2.DataSource = comboBoxItems;
            guna2ComboBox2.DisplayMember = "Item2";
            guna2ComboBox2.ValueMember = "Item2";
            guna2ComboBox1.DataSource = listDokter;
            guna2ComboBox1.DisplayMember = "nama";
            guna2ComboBox1.ValueMember = "idDokter";
        }
    }
}
