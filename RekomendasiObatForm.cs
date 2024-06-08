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
    public partial class RekomendasiObatForm : Form
    {
        public RekomendasiObatForm(string penyakit1, string persentase1, string penyakit2, string persentase2, string obat1, string obat2)
        {
            InitializeComponent();
            lbSymptom.Text = penyakit1;
            lbPercentage.Text = persentase1;
            label6.Text = penyakit2;
            label7.Text = persentase2;
            label8.Text = obat1;
            label5.Text = obat2;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
