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
    public partial class GUIForget : Form
    {
        Form login;
        public GUIForget(Form login)
        {
            InitializeComponent();
            this.login = login;
            txtUsername.Text = GUILogin.userName;
        }

        private void bAgree_Click(object sender, EventArgs e)
        {
            if(BLLTRAIN.Instance.CheckSecurity(txtUsername.Text, cbbQuestion.Text, txtAnswer.Text))
            {
                GUIChangePass change = new GUIChangePass(login, this, txtUsername.Text);
                this.Hide();
                change.Show();
            }
            else
            {
                MessageBox.Show("Câu trả lời của bạn không đúng!");
                return;
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            cbbQuestion.Items.Clear();
            cbbQuestion.Items.AddRange(BLLTRAIN.Instance.GetQuestionSecurity(txtUsername.Text).ToArray());
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(txtUsername.Text != "")
                if (!BLLTRAIN.Instance.check(txtUsername.Text))
                {
                    MessageBox.Show("Không tồn tại tên đăng nhập bạn nhập!");
                    txtUsername.Text = "";
                }
        }
    }
}
