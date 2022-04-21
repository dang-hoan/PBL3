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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btdangnhap_Click_1(object sender, EventArgs e)
        {
            if (txtusername.Text == "1")
            {
                Form1 f = new Form1(this);
                f.Show();
                this.Hide();
            }
            else if(txtusername.Text == "2")
            {

            }
            else if(txtusername.Text == "3")
            {
                GUI g = new GUI(this);
                g.Show();
                this.Hide();
            }
            txtusername.Text = "";
            txtpass.Text = "";
        }

        private void linkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            txtpass.Text = "";
            GUIForget Forget = new GUIForget(this);
            Forget.Show();
        }
    }
}
