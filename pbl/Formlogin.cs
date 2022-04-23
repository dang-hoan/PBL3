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
        ManageFunction man = new ManageFunction();
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
            int result = man.checkAccount(txtusername.Text, txtpass.Text);
            switch (result)
            {
                case 0:
                    {
                        labelNotify.Text = "*Tên đăng nhập hoặc mật khẩu không đúng!";
                        labelNotify.Location = new Point(panel1.Location.X + 40, btdangnhap.Location.Y - 20);
                        labelNotify.BackColor = Color.Transparent;
                        labelNotify.ForeColor = Color.White;
                        break;
                    }
                case 1:
                    {
                        Form1 f = new Form1(this);
                        f.Show();
                        this.Hide();
                        break;
                    }
                case 2:
                    {
                        Employeechinh f = new Employeechinh(this);
                        f.Show();
                        this.Hide();
                        break;
                    }
                case 3:
                    {
                        GUI g = new GUI(this);
                        g.Show();
                        this.Hide();
                        break;
                    }
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
