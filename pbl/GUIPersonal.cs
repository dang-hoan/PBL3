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
    public partial class GUIPersonal : Form
    {
        ManageFunction man = new ManageFunction();
        public GUIPersonal()
        {
            InitializeComponent();
            GUI();
        }
        private void GUI()
        {
            DataTable dt = man.getInfo(Formlogin.userName);

            //infor
            txtUsername.Text = dt.Rows[0][0].ToString();
            txtName.Text = dt.Rows[0][1].ToString();
            if (Convert.ToBoolean(dt.Rows[0][2].ToString()))
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtBirthDay.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
            txtAddress.Text = dt.Rows[0][4].ToString();
            txtIDCard.Text = dt.Rows[0][5].ToString();
            txtEmail.Text = dt.Rows[0][6].ToString();
            txtPhone.Text = dt.Rows[0][7].ToString();
            txtPosition.Text = dt.Rows[0][9].ToString();
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
            else if (man.setPass(Formlogin.userName, txtOld.Text, txtNew.Text))
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
            man.setInfo(Formlogin.userName, txtName.Text, rbMale.Checked || !rbFemale.Checked, txtBirthDay.Value.ToString("yyyy/MM/dd"), txtAddress.Text, txtIDCard.Text, txtEmail.Text, txtPhone.Text);
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
