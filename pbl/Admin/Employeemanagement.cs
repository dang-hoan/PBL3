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
    public partial class Employeemanagement : Form
    {
        Form form;
        public Employeemanagement(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
        private void pAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
