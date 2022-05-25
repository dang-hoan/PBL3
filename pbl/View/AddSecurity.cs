using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.DTO;

namespace pbl
{
    public partial class AddSecurity : Form
    {
        List<SECURITY> Sec = new List<SECURITY>();
        public delegate void MyDel(List<SECURITY> Secur);
        public MyDel GetSecurity;
        private int count = 0;
        public AddSecurity()
        {
            InitializeComponent();
        }
        private void bAddNew_Click(object sender, EventArgs e)
        {
            txtQuestion1.Text = "";
            txtAnswer1.Text = "";
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Sec.Add(new SECURITY
            {
                OwnUN = GUILogin.userName,
                Question = txtQuestion1.Text,
                Answer = txtAnswer1.Text
            });
            MessageBox.Show("Thêm câu hỏi bảo mật thành công!");
        }
        private void AddList()
        {
            int num = 1;
            foreach(SECURITY sec in Sec)
            {
                cbbQuestion2.Items.Add(new CBBSecurity
                {
                    Value = sec.SecurityID,
                    Text = num++ + ". " + sec.Question
                });
            }
        }
        private void GetAnswer()
        {
            foreach(SECURITY sec in Sec)
            {
                if(sec.SecurityID == ((CBBSecurity)cbbQuestion2.SelectedItem).Value)
                {
                    txtAnswer2.Text = sec.Answer;
                    return;
                }
            }
        }
        private void bEdit_Click(object sender, EventArgs e)
        {
            cbbQuestion2.Items.Clear();
            AddList();
            GetAnswer();
            cbbQuestion2.Enabled = true;
            txtAnswer2.Enabled = true;
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (cbbQuestion2.Text == "") return;
            foreach(SECURITY sec in Sec)
            {
                if(sec.SecurityID == ((CBBSecurity)cbbQuestion2.SelectedItem).Value)
                {
                    sec.SecurityID = count++;
                    sec.Answer = txtAnswer2.Text;
                }
            }
            MessageBox.Show("Lưu câu hỏi bảo mật thành công!");
            txtAnswer2.Text = "";
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            GetSecurity(Sec);
            this.Close();
        }

        private void cbbQuestion2_Click(object sender, EventArgs e)
        {
            cbbQuestion2.Items.Clear();
            AddList();
        }

        private void cbbQuestion2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (SECURITY sec in Sec)
            {
                if (sec.SecurityID == ((CBBSecurity)cbbQuestion2.SelectedItem).Value)
                {
                    txtAnswer2.Text = sec.Answer;
                }
            }
        }
    }
}
