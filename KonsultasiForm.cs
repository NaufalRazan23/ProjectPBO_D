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
    public partial class KonsultasiForm : BaseForm
    {
        public KonsultasiForm() : base()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            RekomendasiObatForm rekomendasiObatForm = new RekomendasiObatForm();
            rekomendasiObatForm.Show();
            this.Hide();
            rekomendasiObatForm.FormClosed += (s, args) => this.Close();
        }

    }
}
