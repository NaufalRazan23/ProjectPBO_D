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
    public partial class TampilanAntrianUntukDokter : Form
    {
        Antrian? antrianSekarangDiLabelIni;
        AdminAntrianController adminAntrianController;
        List<List<string>> listLabel;
        int indexLabelSekarang;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public TampilanAntrianUntukDokter()
        {
            InitializeComponent();
            adminAntrianController = new AdminAntrianController();
            listLabel = adminAntrianController.getLabel();
            refreshAntrian();
            timer.Tick += (s, args) => refreshAntrian();
            timer.Interval = 3000;
            timer.Start();
        }
        public void refreshAntrian()
        {
            lblJenisDokter.Text = listLabel[indexLabelSekarang][1];
            adminAntrianController.listAntrian = adminAntrianController.getAntrian();
            antrianSekarangDiLabelIni = adminAntrianController.getAntrianSekarang(listLabel[indexLabelSekarang][0]);
            if (antrianSekarangDiLabelIni != null)
            {
                var pad = antrianSekarangDiLabelIni.nomorAntrian.ToString("000");
                string nomorBaru = $"{antrianSekarangDiLabelIni.labelAntrian}   {pad[0]}   {pad[1]}   {pad[2]}";
                lblNomorAntrian.Text = nomorBaru;
                lblKeterangan.Text = $"Atas Nama: {antrianSekarangDiLabelIni.atasNama}\nStatus: {antrianSekarangDiLabelIni.statusAntrian}";
            }
            else
            {
                lblNomorAntrian.Text = $"{listLabel[indexLabelSekarang][0]}   0   0   0";
                lblKeterangan.Text = $"Atas Nama: -\nStatus: -";
            }
        }
     


        private void lblNxtDoc_Click(object sender, EventArgs e)
        {
            if (indexLabelSekarang + 1 < listLabel.Count)
            {
                indexLabelSekarang++;
                refreshAntrian();
            }
        }

 

        private void btnTandaiSelesai_Click(object sender, EventArgs e)
        {
            if (antrianSekarangDiLabelIni != null)
            {
                adminAntrianController.tandaiSelesai(antrianSekarangDiLabelIni);
            }
            this.refreshAntrian();
        }

        private void BtnPrevdkt_Click(object sender, EventArgs e)
        {
            if(indexLabelSekarang == 0)
            {
                this.Close();
                return;
            }
            indexLabelSekarang--;
            refreshAntrian();
        }
    }
}
