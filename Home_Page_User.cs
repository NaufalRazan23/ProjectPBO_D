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
    public partial class Home_Page_User : Form
    {
        public Home_Page_User()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            buatantrian buatantrian = new buatantrian();
            buatantrian.Show();
            this.Hide();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            KonsultasiForm konsultasiForm = new KonsultasiForm();
            konsultasiForm.Show();
            this.Hide();
        }

        private void label_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Page_User_Load(object sender, EventArgs e)
        {

        }
    }
}
