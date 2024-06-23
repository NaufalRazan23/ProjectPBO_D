using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPBO.Components
{
    public partial class SymptomPercentage : UserControl
    {

        [Category("Custom Props")]
        public string SymptomName
        {
            get { return lbSymptom.Text; }
            set { lbSymptom.Text = value; }
        }

        [Category("Custom Props")]
        public string Percentage
        {
            get { return lbPercentage.Text; }
            set { lbPercentage.Text = value; }
        }

        public SymptomPercentage()
        {
            InitializeComponent();
        }

    }
}
