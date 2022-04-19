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
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "1")
            {
                Form1 Admin = new Form1(this);
                Admin.Show();
                this.Hide();
            }
            else if(txtUsername.Text == "2")
            {

            }
            else if(txtUsername.Text == "3")
            {
                GUI form3 = new GUI(this);
                form3.Show();
                this.Hide();
            }
        }
    }
}
