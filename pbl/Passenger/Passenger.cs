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
    public partial class Passenger : Form
    {
        Form form;
        public Passenger(Form form)
        {
            InitializeComponent();
            labelName.Text = Form1.name;
            this.form = form;
        }

        private void pInfor_Click(object sender, EventArgs e)
        {
            this.Hide();
            personinfor infor = new personinfor(this);
            infor.Show();
        }

        private void pSchedule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Schedule schedule = new Schedule(this);
            schedule.Show();
        }

        private void pTicket_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket ticket = new Ticket(this);
            ticket.Show();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
