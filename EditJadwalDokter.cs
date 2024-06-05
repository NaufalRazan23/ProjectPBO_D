using ProjectPBO.Data;
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

        private List<DoktorSpesialis> doktorSpesialis = new List<DoktorSpesialis>();
        private List<DoktorSpesialis> doktorSpesialis2 = new List<DoktorSpesialis>();

        public EditJadwalDokter()
        {
            InitializeComponent();
            doktorSpesialis.Add(new DoktorSpesialis("Dr. Amanda", "Anak", "Senin", "09:00-12:00"));
            doktorSpesialis.Add(new DoktorSpesialis("Dr. Brian", "Kandungan", "", "13:00-16:00"));
            doktorSpesialis.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis.Add(new DoktorSpesialis("Dr. Clara", "Gigi dan Mulut", "Selasa", "08:00-11:00"));
            doktorSpesialis.Add(new DoktorSpesialis("Dr. David", "Mata", "", "13:00-16:00"));
            doktorSpesialis.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis.Add(new DoktorSpesialis("Dr. Elena", "Psikiater", "Rabu", "10:00 - 13:00"));
            doktorSpesialis.Add(new DoktorSpesialis("Dr. Farhan", "THT", "", "14:00 - 17:00"));
            doktorSpesialis.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis.Add(new DoktorSpesialis("Dr. Grace", "Kulit dan Kelamin", "Kamis", "08:30 - 11:30"));
            doktorSpesialis.Add(new DoktorSpesialis("Dr. Henry", "Jantung", "", "13:30 - 16:30"));
            doktorSpesialis.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis.Add(new DoktorSpesialis("", "", "", ""));

            doktorSpesialis2.Add(new DoktorSpesialis("Dr. Ingrid", "Mata", "Jumat", "09:00 - 12:00"));
            doktorSpesialis2.Add(new DoktorSpesialis("Dr. Jack", "Anak", "", "14:00 - 17:00"));
            doktorSpesialis2.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis2.Add(new DoktorSpesialis("", "", "", ""));

            doktorSpesialis2.Add(new DoktorSpesialis("Dr. Kelly", "THT", "Sabtu", "08:30 - 11:30"));
            doktorSpesialis2.Add(new DoktorSpesialis("Dr. Ratio", "Kandungan", "", "13:30 - 16:30"));
            doktorSpesialis2.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis2.Add(new DoktorSpesialis("", "", "", ""));


            doktorSpesialis2.Add(new DoktorSpesialis("", "", "Minggu", ""));
            doktorSpesialis2.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis2.Add(new DoktorSpesialis("", "", "", ""));
            doktorSpesialis2.Add(new DoktorSpesialis("", "", "", ""));

            guna2DataGridView1.DataSource = doktorSpesialis;
            guna2DataGridView2.DataSource = doktorSpesialis2;
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

    }
}
