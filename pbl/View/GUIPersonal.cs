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
using pbl.View;

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
            cbbQuestion.Items.AddRange(BLLTRAIN.Instance.GetQuestionSecurity(GUILogin.userName).ToArray());
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
            else if (BLLTRAIN.Instance.UpdatePass(GUILogin.userName, txtOld.Text, txtNew.Text))
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
        private bool CheckNumber(string txt)
        {
            foreach (char i in txt)
            {
                if (i < 48 || i > 57) return false;
            }
            return true;
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
            BLLTRAIN.Instance.UpdatePEOPLE(new PEOPLE
            {
                Username = GUILogin.userName,
                Name = txtName.Text,
                Gender = rbMale.Checked || !rbFemale.Checked,
                BirthDay = txtBirthDay.Value,
                Address = txtAddress.Text,
                IDCard = txtIDCard.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            });
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bEditSecurity_Click(object sender, EventArgs e)
        {
            cbbQuestion.Enabled = true;
            txtAnswer.Enabled = true;
        }

        private void bSaveSecurity_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.UpdateSecurity(GUILogin.userName, cbbQuestion.Text, txtAnswer.Text);
            MessageBox.Show("Đã đổi thành công câu trả lời bảo mật của bạn!");
            cbbQuestion.Enabled = false;
            txtAnswer.Enabled = false;
        }

        private void cbbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAnswer.Text = BLLTRAIN.Instance.GetAnswerSecurity(GUILogin.userName, cbbQuestion.Text);
        }
    }
}
