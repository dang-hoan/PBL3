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
    public partial class Employee : Form
    {
        Form form;
        public Employee(Form form)
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

        private void pSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedulemanagement f=new Schedulemanagement(this);
            f.Show();
        }

        private void pPassenger_Click(object sender, EventArgs e)
        {
            this.Hide();
            Passengermeployee f =  new Passengermeployee(this);
            f.Show();
        }

        private void pTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticketmanagement f = new Ticketmanagement(this);
            f.Show();
        }
        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
