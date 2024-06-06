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
    public partial class buatantrian : Form
    {
        public buatantrian()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            Jadwal_dokter_spesialis jadwalDokterSpesialisForm = new Jadwal_dokter_spesialis();

            jadwalDokterSpesialisForm.Show();

            this.Hide();

            jadwalDokterSpesialisForm.FormClosed += (s, args) => this.Close();

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buatantrian_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void IniNamaLengkap_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
