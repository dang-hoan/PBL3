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
            txtBirthDay.MaxDate = DateTime.Now;
        }
        private void InitQuestion()
        {
            int num = 1;
            cbbQuestion.Items.Clear();
            foreach (SECURITY s in BLLTRAIN.Instance.GetQuestionSecurity(GUILogin.userName))
            {
                cbbQuestion.Items.Add(new CBBSecurity
                {
                    Value = s.SecurityID,
                    Text = num++ + ". " + s.Question
                });
            }
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
            txtBirthDay.Value = (DateTime)p.BirthDay;
            txtAddress.Text = p.Address;
            txtIDCard.Text = p.IDCard;
            txtEmail.Text = p.Email;
            txtPhone.Text = p.Phone;
            txtPosition.Text = p.Position;
            InitQuestion();
        }
        private void bEditPass_Click(object sender, EventArgs e)
        {
            txtOld.Enabled = true;
            txtNew.Enabled = true;
            txtConfirm.Enabled = true;
        }

        private void bSavePass_Click(object sender, EventArgs e)
        {
            if (txtOld.Enabled == false) return;
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
            if (txtName.Enabled == false) return;
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
            InputPass input = new InputPass();
            input.GetConfirmPass = new InputPass.MyDel(GetConfirmPass);
            input.ShowDialog();
            if (Confirm == 0) return;
            if (Confirm == -1)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!");
                return;
            }
            else
            {
                Confirm = -1;
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
        public int Confirm = 0;
        private void GetConfirmPass(string ConfirmPass, bool Get)
        {
            if(Get == false)
            {
                Confirm = 0;
            }
            else if (BLLTRAIN.Instance.CheckAccount(GUILogin.userName, ConfirmPass) == "Không tồn tại")
            {
                Confirm = -1;
            }
            else Confirm = 1;
        }
        private void bEditSecurity_Click(object sender, EventArgs e)
        {
            InputPass input = new InputPass();
            input.GetConfirmPass = new InputPass.MyDel(GetConfirmPass);
            input.ShowDialog();
            if (Confirm == 0) return;
            if (Confirm == -1)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!");
                return;
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận chính xác!");
                Confirm = -1;
            }
            if (cbbQuestion.Text != "")
                txtAnswer.Text = BLLTRAIN.Instance.GetAnswerSecurity(GUILogin.userName, ((CBBSecurity)cbbQuestion.SelectedItem).Value);
            cbbQuestion.Enabled = true;
            txtAnswer.Enabled = true;
        }

        private void bSaveSecurity_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "")
            {
                MessageBox.Show("Để bảo đảm an toàn cho bạn, bạn không được phép tạo câu trả lời bảo mật rỗng!");
                return;
            }
            if (cbbQuestion.Text == "")
            {
                cbbQuestion.Enabled = false;
                txtAnswer.Enabled = false;
                return;
            }
            if (txtAnswer.Enabled == false) return;
            BLLTRAIN.Instance.UpdateSecurity(GUILogin.userName, ((CBBSecurity)cbbQuestion.SelectedItem).Value, txtAnswer.Text);
            MessageBox.Show("Đã đổi thành công câu trả lời bảo mật của bạn!");
            txtAnswer.Text = "";
            cbbQuestion.Enabled = false;
            txtAnswer.Enabled = false;
        }

        private void cbbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((CBBSecurity)cbbQuestion.SelectedItem != null)
                txtAnswer.Text = BLLTRAIN.Instance.GetAnswerSecurity(GUILogin.userName, ((CBBSecurity)cbbQuestion.SelectedItem).Value);
        }
        private void GetSecurity(List<SECURITY> list)
        {
            if(list != null) BLLTRAIN.Instance.AddSecurity(list);
            InitQuestion();
        }
        private void pAdd_Click(object sender, EventArgs e)
        {
            InputPass input = new InputPass();
            input.GetConfirmPass = new InputPass.MyDel(GetConfirmPass);
            input.ShowDialog();
            if (Confirm == 0) return;
            if (Confirm == -1)
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng!");
                return;
            }
            else
            {
                Confirm = -1;
            }
            AddSecurity add = new AddSecurity();
            add.GetSecurity = new AddSecurity.MyDel(GetSecurity);
            add.ShowDialog();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (cbbQuestion.Enabled == false) return;
            if (cbbQuestion.SelectedItem == null) return;
            //InputPass input = new InputPass();
            //input.GetConfirmPass = new InputPass.MyDel(GetConfirmPass);
            //input.ShowDialog();
            //if (Confirm == 0) return;
            //if (Confirm == -1)
            //{
            //    MessageBox.Show("Mật khẩu xác nhận không đúng!");
            //    return;
            //}
            //else
            //{
            //    Confirm = -1;
            //}
            BLLTRAIN.Instance.DelSecurity(((CBBSecurity)cbbQuestion.SelectedItem).Value);
            MessageBox.Show("Đã xoá thành công câu hỏi bảo mật bạn chọn!");
            cbbQuestion.SelectedItem = null;
            txtAnswer.Text = "";
            InitQuestion();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
        private bool CheckName(string Name)
        {
            foreach(char i in Name)
            {
                if(i < 65 || i > 90 || i < 97 || i > 122 || i != ' ')
                {
                    return false;
                }
            }
            return true;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!CheckName(Name)) labName.Text = "*Tên không hợp lệ (tên chỉ chứa khoảng trắng và các ký tự trong bảng chữ cái!";
            else labName.Text = "";
        }

        private void txtBirthDay_FontChanged(object sender, EventArgs e)
        {
            string s = txtBirthDay.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            if(string.Compare(s, now) > 0)
            {
                labBirthDay.Text = "*Ngày sinh không thể sau thời điểm hiện tại";
                return;
            }
            labBirthDay.Text = "";
        }
    }
}
