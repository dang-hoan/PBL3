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
    public partial class Admin : Form
    {
        Form form;
        public Admin(Form form)
        {
            InitializeComponent();
            labelName.Text = Form1.name;
            this.form = form;
        }

        private void pInfor_Click(object sender, EventArgs e)
        {
            this.Hide();
            personinfor f = new personinfor(this);
            f.Show();
        }

        private void pEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employeemanagement f = new Employeemanagement(this);
            f.Show();
        }

        private void pPassenger_Click(object sender, EventArgs e)
        {
            this.Hide();
            Passengermanagement p = new Passengermanagement(this);
            p.Show();
        }

        private void pSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedulemanagement p = new Schedulemanagement(this);
            p.Show();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
