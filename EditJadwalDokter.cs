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
    public partial class EditJadwalDokter : Form
    {
        private JadwalController jadwalController;
        public EditJadwalDokter()
        {
            InitializeComponent();
            jadwalController = new JadwalController();
            refresh();
        }

        private void refresh()
        {
            jadwalController.listJadwal = jadwalController.getListJadwal();
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            this.CHari.DataPropertyName = "hari";
            this.CMulai.DataPropertyName = "jamMulai";
            this.CSelesai.DataPropertyName = "jamSelesai";
            this.CDokter.DataPropertyName = "DisplayNama";
            this.CJenis.DataPropertyName = "DisplayJenis";
            this.dataGridView1.DataSource = jadwalController.listJadwal;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditJadwalDokter_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0) { return; }
            var selected = (Jadwal)selectedRows[0].DataBoundItem;
            var id = selected.idJadwal;

            MINIHapusJadwal mINIHapusJadwal = new MINIHapusJadwal();
            DialogResult dialogResult = mINIHapusJadwal.ShowDialog();
            if (DialogResult.OK == dialogResult)
            {
                jadwalController.hapus(id);
                refresh();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selectedRows = dataGridView1.SelectedRows;
            if (selectedRows.Count == 0) { return; }
            var selected = (Jadwal)selectedRows[0].DataBoundItem;
            var id = selected.idJadwal;
            var idDokter = selected.dokter.idDokter;
            var hari = selected.hari;
            var mulai = selected.jamMulai;
            var selesai = selected.jamSelesai;

            MINIEditJadwalPop mINIEditJadwalPop = new MINIEditJadwalPop();
            List<Dokter> listDokter = jadwalController.getListDokter();
            int indexDokterSebelumnya = listDokter.FindIndex((dokter) => dokter.idDokter == idDokter);
            int indexHariSebelumnya = JadwalController.HariKeInteger(hari);
            TimeOnly mulaiSebelumnya = mulai;
            TimeOnly selesaiSebelumnya = selesai;

            mINIEditJadwalPop.idJadwal = id;
            mINIEditJadwalPop.listDokter = listDokter;
            mINIEditJadwalPop.indexDokterSebelumnya = indexDokterSebelumnya;
            mINIEditJadwalPop.indexHariSebelumnya = indexHariSebelumnya;
            mINIEditJadwalPop.mulaiSebelumnya = mulaiSebelumnya;
            mINIEditJadwalPop.selesaiSebelumnya = selesaiSebelumnya;
            DialogResult dialogResult = mINIEditJadwalPop.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                jadwalController.edit(mINIEditJadwalPop.jadwal);
                refresh();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            MINITambahJadwal mINITambahJadwal = new MINITambahJadwal();
            List<Dokter> listDokter = jadwalController.getListDokter();
            mINITambahJadwal.listDokter = listDokter;
            DialogResult = mINITambahJadwal.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                var jadwalBaru = mINITambahJadwal.jadwal;
                jadwalController.tambah(jadwalBaru);
                refresh();
            }
        }
    }
}
