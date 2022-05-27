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

namespace pbl
{
    public partial class GUIChangePass : Form
    {
        Form login, forget;
        string userName;
        public GUIChangePass(Form login, Form forget, string userName)
        {
            InitializeComponent();
            this.login = login;
            this.forget = forget;
            this.userName = userName;
        }

        private void bAgree_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text == "" || txtConfirmPass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }
            if (!txtNewPass.Text.Equals(txtConfirmPass.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp với mật khẩu mới!");
                return;
            }
            if(txtConfirmPass.Text.Length > 12 || txtNewPass.Text.Length > 12)
            {
                MessageBox.Show("Mật khẩu không được quá 12 ký tự!");
                return;
            }
            BLLTRAIN.Instance.UpdatePassByForget(userName, txtNewPass.Text);
            MessageBox.Show("Đã thay đổi thành công mật khẩu của bạn!");
            this.Close();
            login.Show();
        }

        private void txtConfirmPass_Leave(object sender, EventArgs e)
        {
            if(txtConfirmPass.Text.Length > 12) MessageBox.Show("Mật khẩu không được quá 12 ký tự!");
        }

        private void txtNewPass_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Length > 12) MessageBox.Show("Mật khẩu không được quá 12 ký tự!");
        }

        private void cbViewPass_Click(object sender, EventArgs e)
        {
            if (cbViewPass.Checked)
            {
                txtNewPass.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtNewPass.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            forget.Show();
        }
    }
}
