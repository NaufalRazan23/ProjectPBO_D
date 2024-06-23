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
    public partial class MINIEditJadwalPop : Form
    {
        public List<Dokter> listDokter;
        public Jadwal? jadwal;
        public int idJadwal;
        public int indexDokterSebelumnya;
        public int indexHariSebelumnya;
        public TimeOnly mulaiSebelumnya;
        public TimeOnly selesaiSebelumnya;

        public MINIEditJadwalPop()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string hari = (string)guna2ComboBox2.SelectedValue;
            TimeOnly jamMulai = TimeOnly.FromDateTime(dtpMulai.Value);
            TimeOnly jamSelesai = TimeOnly.FromDateTime(dtpSelesai.Value);
            int idDokter = (int)guna2ComboBox1.SelectedValue;
            this.jadwal = new Jadwal(idJadwal, hari, jamSelesai, jamMulai, new Dokter(idDokter, "", "", ""));
            DialogResult = DialogResult.OK;
            Close();
        }

        private void MINIEditJadwalPop_Load(object sender, EventArgs e)
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
            guna2ComboBox2.SelectedIndex = indexHariSebelumnya;
            guna2ComboBox1.DataSource = listDokter;
            guna2ComboBox1.DisplayMember = "nama";
            guna2ComboBox1.ValueMember = "idDokter";
            guna2ComboBox1.SelectedIndex = indexDokterSebelumnya;
            dtpMulai.Value = (new DateTime(2022, 1, 1)) + mulaiSebelumnya.ToTimeSpan();
            dtpSelesai.Value = (new DateTime(2022, 1, 1)) + selesaiSebelumnya.ToTimeSpan();
        }
    }
}
