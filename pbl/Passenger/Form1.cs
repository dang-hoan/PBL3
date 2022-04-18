using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace pbl
{
    public partial class Form1 : Form
    {
        public static string name { get; }
        public Form1()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "1")
            {
                this.Hide();
                Admin f = new Admin(this);
                f.Show();
            }
            else if (txtID.Text == "2")
            {
                this.Hide();
                Employee f = new Employee(this);
                f.Show();
            }
            else if(txtID.Text == "3")
            {
                this.Hide();
                Passenger f = new Passenger(this);
                f.Show();
            }
        }

    }
}
