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
using pbl.DTO;

namespace pbl
{
    public partial class GUIPersonal : Form
    {
        public GUIPersonal()
        {
            InitializeComponent();
            GUI();
        }
        private void GUI()
        {
            PEOPLE_View p = BLLTRAIN.Instance.GetPEOPLEViewByUsername(GUILogin.userName)[0];
            //infor
            txtUsername.Text = p.Username;
            txtName.Text = p.Name;
            if (p.Gender.Equals("Nam"))
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtBirthDay.Value = p.BirthDay;
            txtAddress.Text = p.Address;
            txtIDCard.Text = p.IDCard;
            txtEmail.Text = p.Email;
            txtPhone.Text = p.Phone;
            txtPosition.Text = p.Position;
        }
        private void bEditPass_Click(object sender, EventArgs e)
        {
            txtOld.Enabled = true;
            txtNew.Enabled = true;
            txtConfirm.Enabled = true;
        }

        private void bSavePass_Click(object sender, EventArgs e)
        {
            if (!txtNew.Text.Equals(txtConfirm.Text))
            {
                MessageBox.Show("Mật khẩu xác nhận và mật khẩu mới không khớp!");
            }
            else if(txtOld.Text == "")
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
            else if (BLLTRAIN.Instance.UpdatePass(GUILogin.userName, txtOld.Text, txtNew.Text) == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                txtOld.Text = "";
                txtNew.Text = "";
                txtConfirm.Text = "";
                txtOld.Enabled = false;
                txtNew.Enabled = false;
                txtConfirm.Enabled = false;
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
        }

        private void bEditInfor_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            rbMale.Enabled = true;
            rbFemale.Enabled = true;
            txtBirthDay.Enabled = true;
            txtAddress.Enabled = true;
            txtIDCard.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
        }

        private void bSaveInfor_Click(object sender, EventArgs e)
        {
            if(BLLTRAIN.Instance.UpdatePEOPLE(new PEOPLE
            {
                Username = GUILogin.userName,
                Name = txtName.Text,
                Gender = rbMale.Checked ? "Nam" : "Nữ",
                BirthDay = txtBirthDay.Value,
                Address = txtAddress.Text,
                IDCard = txtIDCard.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            }) == 1)
            {
                MessageBox.Show("Chỉnh sửa thông tin thành công!");
                txtName.Enabled = false;
                rbMale.Enabled = false;
                rbFemale.Enabled = false;
                txtBirthDay.Enabled = false;
                txtAddress.Enabled = false;
                txtIDCard.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;
            }
        }
    }
}
