using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPBO
{
    public class BaseForm : Form
    {
        protected Form? parentForm;


        public BaseForm SetParentForm(Form parentForm)
        {
            this.parentForm = parentForm;
            return this;
        }

        public void ReturnAndCloseForm()
        {
            this.Close();
            this.parentForm?.Show();
        }
    }
}
