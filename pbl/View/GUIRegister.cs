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
        private bool CheckNumber(string txt)
        {
            foreach (char i in txt)
            {
                if (i < 48 || i > 57) return false;
            }
            return true;
        }
        private void bContinue_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPass.Text == "" || txtConfirmPass.Text == "" || 
                txtIDCard.Text == "" || txtPhone.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu bắt buộc!");
                return;
            }
            if (BLLTRAIN.Instance.check(txtUsername.Text)){
                MessageBox.Show("Tên đăng nhập đã tồn tại! Vui lòng chọn tên khác!");
                return;
            }
            if (!txtPass.Text.Equals(txtConfirmPass.Text))
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp với mật khẩu trước đó!");
                return;
            }
            if (!CheckNumber(txtIDCard.Text))
            {
                MessageBox.Show("Số căn cước công dân phải có dạng số!");
                return;
            }
            if (!CheckNumber(txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại phải có dạng số!");
                return;
            }
            if (txtIDCard.Text.Length > 12)
            {
                MessageBox.Show("Số căn cước công dân chỉ có 12 chữ số!");
                return;
            }
            if (txtIDCard.Text.Length < 12)
            {
                MessageBox.Show("Số căn cước công dân phải đủ 12 chữ số!");
                return;
            }
            if (txtPhone.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại chỉ có 10 chữ số!");
                return;
            }
            if (txtPhone.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 chữ số!");
                return;
            }
            string sa = txtBirthDay.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.AddYears(-15).ToString("yyyy/MM/dd HH:mm");
            if (string.Compare(sa, now) > 0)
            {
                MessageBox.Show("Người dùng tối thiểu phải đủ 15 tuổi!");
                return;
            }
            if (!txtEmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Email không đúng định dạng!");
                return;
            }
            else
            {
                if ("@gmail.com".IndexOf(txtEmail.Text) != "@gmail.com".LastIndexOf(txtEmail.Text))
                {
                    MessageBox.Show("Email không đúng định dạng!");
                    return;
                }
            };
            if (BLLTRAIN.Instance.CheckIDCard2("", txtIDCard.Text))
            {
                MessageBox.Show("Số căn cước công dân bạn nhập đã tồn tại trong hệ thống!");
                return;
            }
            if (BLLTRAIN.Instance.CheckPhone("", txtPhone.Text))
            {
                MessageBox.Show("Số điện thoại bạn nhập đã tồn tại trong hệ thống!");
                return;

            }
            if (BLLTRAIN.Instance.CheckEmail("", txtEmail.Text))
            {
                MessageBox.Show("Email bạn nhập đã tồn tại trong hệ thống!");
                return;
            }
            BLLTRAIN.Instance.AddPassenger(new PEOPLE {
                Username = txtUsername.Text,
                Name = txtName.Text,
                Gender = rbMale.Checked || !rbFemale.Checked,
                BirthDay = txtBirthDay.Value,
                Address = txtAddress.Text,
                IDCard = txtIDCard.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            });
            BLLTRAIN.Instance.AddLogin(new LOGIN { Username = txtUsername.Text, PassWord = txtPass.Text });
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
