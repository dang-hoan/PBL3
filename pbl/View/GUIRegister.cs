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
    public partial class GUIRegister : Form
    {
        private Form login;
        public GUIRegister(Form login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void cbViewPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViewPass.Checked)
            {
                txtPass.PasswordChar = '\0';
                txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '*';
                txtConfirmPass.PasswordChar = '*';
            }
        }

        private void bContinue_Click(object sender, EventArgs e)
        {
            if (BLLTRAIN.Instance.check(txtUsername.Text)){
                MessageBox.Show("Tên đăng nhập đã tồn tại! Vui lòng chọn tên khác!");
                return;
            }
            //BLLpeople.instance.add
            MessageBox.Show("Đăng ký tài khoản thành công!");
            this.Close();
            login.Show();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }
    }
}
