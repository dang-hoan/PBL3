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

namespace pbl.View.Admin
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
            txtBirthDay.MaxDate = DateTime.Now;
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            if (txtBirthDay.Text == "" || txtUsername.Text == "" || txtPass.Text == "" || txtIDCard.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin bắt buộc !");
                return;
            }
            else
            {
                if (labName.Text != "" || labBirthDay.Text != "" || labIDCard.Text != "" || labEmail.Text != "" || labPhone.Text != "" || labUser.Text != "")
                {
                    MessageBox.Show("Bạn nhập thông tin chưa đúng yêu cầu!");
                    return;
                }
                PEOPLE s = new PEOPLE
                {
                    Username = txtUsername.Text,
                    Name = txtName.Text,
                    Gender = rbMale.Checked || !rbFemale.Checked,
                    BirthDay = txtBirthDay.Value,
                    Address = txtAddress.Text,
                    IDCard = txtIDCard.Text,
                    Email = txtEmail.Text,
                    Phone = txtPhone.Text
                };
                LOGIN l = new LOGIN()
                {
                    State = true,
                    PassWord = txtPass.Text,
                    Username = txtUsername.Text,
                };
                BLLpeople.instance.Executenv(s);
                BLLpeople.instance.Execute2(l);
                MessageBox.Show("Đã thêm thành công nhân viên mới!");
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckNumber(string txt)
        {
            foreach (char i in txt)
            {
                if (i < 48 || i > 57) return false;
            }
            return true;
        }
        private bool CheckName(string Name)
        {
            foreach (char i in Name)
            {
                if (i >= 48 && i <= 57)
                {
                    return false;
                }
            }
            return true;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!CheckName(txtName.Text)) labName.Text = "*Tên không thể chứa chữ số!";
            else labName.Text = "";
        }

        private void txtIDCard_TextChanged(object sender, EventArgs e)
        {
            if (txtIDCard.Text == "")
            {
                labIDCard.Text = "*Bắt buộc";
                return;
            }
            if (!CheckNumber(txtIDCard.Text))
            {
                labIDCard.Text = "Số căn cước công dân phải có dạng số!";
                return;
            }
            if (txtIDCard.Text.Length > 12)
            {
                labIDCard.Text = "*Số căn cước công dân chỉ có 12 chữ số!";
                return;
            }
            if (txtIDCard.Text.Length < 12)
            {
                labIDCard.Text = "*Số căn cước công dân phải đủ 12 chữ số!";
                return;
            }
            if (BLLTRAIN.Instance.CheckIDCard2(txtIDCard.Text))
            {
                labIDCard.Text = "*Số căn cước công dân bạn nhập đã tồn tại trong hệ thống!";
                return;
            }
            labIDCard.Text = "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                labEmail.Text = "*Bắt buộc";
                return;
            }
            if (!txtEmail.Text.Contains("@gmail.com"))
            {
                labEmail.Text = "*Email không đúng định dạng!";
                return;
            }
            else
            {
                if ("@gmail.com".IndexOf(txtEmail.Text) != "@gmail.com".LastIndexOf(txtEmail.Text))
                {
                    labEmail.Text = "*Email không đúng định dạng!";
                    return;
                }
            }
            if (BLLTRAIN.Instance.CheckEmail(txtEmail.Text))
            {
                labEmail.Text = "*Email đã tồn tại!";
                return;
            }
            labEmail.Text = "";
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (!CheckNumber(txtPhone.Text))
            {
                labPhone.Text = "*Số điện thoại phải có dạng số!";
                return;
            }
            if (txtPhone.Text == "") labPhone.Text = "*Bắt buộc";
            else if (txtPhone.Text.Length > 10)
            {
                labPhone.Text = "*Số điện thoại chỉ có 10 chữ số!";
                return;
            }
            else if (txtPhone.Text.Length < 10)
            {
                labPhone.Text = "*Số điện thoại phải đủ 10 chữ số!";
                return;
            }
            else if (BLLTRAIN.Instance.CheckPhone(txtPhone.Text))
            {
                labPhone.Text = "*Số điện thoại bạn nhập đã tồn tại trong hệ thống!";
                return;

            }
            labPhone.Text = "";
        }

        private void txtBirthDay_ValueChanged(object sender, EventArgs e)
        {
            string s = txtBirthDay.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.AddYears(-15).ToString("yyyy/MM/dd HH:mm");
            if (string.Compare(s, now) > 0)
            {
                labBirthDay.Text = "*Người dùng tối thiểu phải đủ 15 tuổi!";
                return;
            }
            labBirthDay.Text = "";

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                labUser.Text = "*Bắt buộc";
                return;
            }
            if (BLLTRAIN.Instance.check(txtUsername.Text))
            {
                labUser.Text = "*Username đã tồn tại!";
                return;
            }
            labUser.Text = "";
        }
    }
}
