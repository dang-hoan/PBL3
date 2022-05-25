using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;
using pbl.View;
using pbl.View.Admin;



namespace pbl
{
    public partial class GUILogin : Form
    {
        public static string userName;
        public GUILogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void btdangnhap_Click_1(object sender, EventArgs e)
        {
            userName = txtusername.Text;
            if (txtusername.Text == "" || txtpass.Text == "")
            {
                labelNotify.Text = "*Thông tin đăng nhập chưa đủ!";
                labelNotify.Location = new Point(panel1.Location.X + 90, btdangnhap.Location.Y - 20);
                labelNotify.BackColor = Color.Transparent;
                labelNotify.ForeColor = Color.White;
                return;
            }
            string result = BLLTRAIN.Instance.CheckAccount(txtusername.Text, txtpass.Text);
            switch (result)
            {
                case "Không tồn tại":
                    {
                        labelNotify.Text = "*Tên đăng nhập hoặc mật khẩu không đúng!";
                        labelNotify.Location = new Point(panel1.Location.X + 40, btdangnhap.Location.Y - 20);
                        labelNotify.BackColor = Color.Transparent;
                        labelNotify.ForeColor = Color.White;
                        return;
                    }
                case "Giám đốc":
                    {
                        //Form1 f = new Form1(this);
                        Mainform f = new Mainform(this);
                        f.Show();
                        this.Hide();
                        break;
                    }
                case "Nhân viên":
                    {
                        Employeechinh f = new Employeechinh(this);
                        f.Show();
                        this.Hide();
                        break;
                    }
                case "Khách hàng":
                    {
                        GUI g = new GUI(this, txtusername.Text);
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
            userName = txtusername.Text;
            this.Hide();
            txtpass.Text = "";
            GUIForget Forget = new GUIForget(this);
            Forget.Show();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GUIRegister reg = new GUIRegister(this);
            reg.Show();
            this.Hide();
        }

        private void Formlogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btdangnhap_Click_1(sender, e);
            }
        }

        private void cbViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewPass.Checked) txtpass.PasswordChar = '\0';
            else txtpass.PasswordChar = '*';
        }
    }
}
