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
    public partial class Ticketmanagement : Form
    {
        Form form;
        public Ticketmanagement(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            addticket f = new addticket(this);
            f.Show();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
