﻿using System;
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
            if(labConfirm.Text != "")
            {
                MessageBox.Show("Bạn nhập thông tin chưa đúng yêu cầu!");
            }
            else if(txtOld.Text == "")
            {
                MessageBox.Show("Mật khẩu cũ không đúng!");
            }
            else if (BLLTRAIN.Instance.UpdatePass(GUILogin.userName, txtOld.Text, txtNew.Text))
            {
                MessageBox.Show("Đổi mật khẩu thành công!");
                txtOld.Enabled = false;
                txtNew.Enabled = false;
                txtConfirm.Enabled = false;
                txtOld.Text = "";
                txtNew.Text = "";
                txtConfirm.Text = "";
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
            if (txtBirthDay.Text == "" || txtUsername.Text == "" || txtIDCard.Text == "" || txtEmail.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin bắt buộc !");
                return;
            }
            if (labName.Text != "" || labBirthDay.Text != "" || labIDCard.Text != "" || labEmail.Text != "" || labPhone.Text != "" || labUser.Text != "")
            {
                MessageBox.Show("Bạn nhập thông tin chưa đúng yêu cầu!");
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
            BLLTRAIN.Instance.DelSecurity(((CBBSecurity)cbbQuestion.SelectedItem).Value);
            MessageBox.Show("Đã xoá thành công câu hỏi bảo mật bạn chọn!");
            cbbQuestion.SelectedItem = null;
            txtAnswer.Text = "";
            InitQuestion();
        }
        private bool CheckName(string Name)
        {
            foreach(char i in Name)
            {
                if(i >= 48 && i <= 57)
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
            if (BLLTRAIN.Instance.CheckIDCard2(GUILogin.userName, txtIDCard.Text))
            {
                labIDCard.Text = "*Số căn cước công dân đã tồn tại!";
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
            if (BLLTRAIN.Instance.CheckEmail(GUILogin.userName, txtEmail.Text))
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
            else if (BLLTRAIN.Instance.CheckPhone(GUILogin.userName, txtPhone.Text))
            {
                labPhone.Text = "*Số điện thoại đã tồn tại!";
                return;

            }
            labPhone.Text = "";
        }

        private void txtNew_TextChanged(object sender, EventArgs e)
        {
            if (txtConfirm.Text != "" && txtNew.Text != "")
            {
                if (txtConfirm.Text != txtNew.Text) labConfirm.Text = "*Mật khẩu xác nhận không khớp với mật khẩu mới!";
                else labConfirm.Text = "";
            }
            else if (txtConfirm.Enabled == true) labConfirm.Text = "*Không thể để trống ô mật khẩu!";
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
    }
}
