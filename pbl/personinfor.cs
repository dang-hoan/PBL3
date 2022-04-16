using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public partial class personinfor : Form
    {
        Form form;
        public personinfor(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void bEditInfor_Click(object sender, EventArgs e)
        {
            txtID.ReadOnly = false;
            txtName.ReadOnly = false;
            txtGmail.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtPosition.ReadOnly = false;
            rbMale.Enabled = true;
            rbFemale.Enabled = true;

        }

        private void bEditPass_Click(object sender, EventArgs e)
        {
            txtOld.ReadOnly = false;
            txtNew.ReadOnly = false;
            txtConfirm.ReadOnly = false;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
