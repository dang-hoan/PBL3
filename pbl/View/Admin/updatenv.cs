using pbl.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl.View.Admin
{
    public partial class updatenv : Form
    {
        public updatenv()
        {
            InitializeComponent();
            shownv();
        }
        public void shownv()
        {

            dtgaddnv.DataSource = BLLpeople.instance.getallnv(222);
        }

        private void idcard_Leave(object sender, EventArgs e)
        {
            if (idcard.Text.Length != 12)
            {
                MessageBox.Show("Id card có 12 số !");
            }
        }

        private void idcard_TextChanged(object sender, EventArgs e)
        {

            if (idcard.Text.Length < 12)
            {
                idcarddk.Text = "Nhập chưa đủ 12 số";
                idcard.BackColor = Color.LightCoral;
            }
            else if (idcard.Text.Length > 12)
            {
                idcarddk.Text = "Nhập quá 12 số";
                idcard.BackColor = Color.LightCoral;
            }
            else
            {
                idcard.BackColor = Color.White;
                idcarddk.Text = "";
            }
        }

        private void txtname_Leave(object sender, EventArgs e)
        {
            if (txtname.Text.Length == 0)
            {
                MessageBox.Show("Họ và tên không được để rỗng !");
            }
        }

        private void gmail_Leave(object sender, EventArgs e)
        {
            if (gmail.Text.Length == 0)
            {
                MessageBox.Show("Gmail không được để rỗng !");
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập không được để rỗng !");
            }
        }

       
        private void gmail_TextChanged(object sender, EventArgs e)
        {
            int count = 0, xam = 0;
            for (int i = 0; i < gmail.Text.Length; i++)
            {
                if (gmail.Text[i] == '.') count++;
                if (gmail.Text[i] == '@') xam++;
            }
            if (count != 1 && xam != 1)
            {
                gmaildkk.Text = "Gmail không đúng định dạng !";
            }
            else
            {
                gmaildkk.Text = "";
            }
            if (gmail.Text.Contains("@gmail.com"))
            {
                gmaildkk.Text = "";
            }
            else
            {
                gmaildkk.Text = "Gmail không đúng định dạngq !";
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            if(gmaildkk.Text != "" ||idcarddk.Text != ""||txtname.Text =="")
            {

                MessageBox.Show("Vui lòng nhập đủ thông tin bắt buộc!");
            }
            else
            {
                PEOPLE s = new PEOPLE()
                {
                    Username = txtusername.Text,
                    Name = txtname.Text,
                    Gender = (male.Checked == true) ? true : false,
                    BirthDay = date.Value,
                    Phone = phone.Text,
                    Address = address.Text,
                    Email = gmail.Text,
                    IDCard = idcard.Text,

                };
                BLLpeople.instance.Executenv(s);
                shownv();
            }
            
        }

        private void dtgaddnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgaddnv.Rows[e.RowIndex];
            if(e.RowIndex >= 0)
            {
                txtname.Text = row.Cells[1].Value.ToString();
                txtusername.Text = row.Cells[0].Value.ToString();
                txtusername.Enabled = false;
                if(row.Cells[2].Value.ToString() == "Nam")
                {
                    male.Checked = true;

                }
                else
                {
                    female.Checked = true;
                }

                gmail.Text = row.Cells[6].Value.ToString();
                phone.Text = row.Cells[7].Value.ToString();
                idcard.Text=row.Cells[5].Value.ToString();
                date.Text=row.Cells[3].Value.ToString();
                address.Text   = row.Cells[4].Value.ToString();
                
            }
        }
    }
}
