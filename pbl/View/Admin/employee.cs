using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


    public partial class employee : Form
    {
        public employee()
        {

            InitializeComponent();
            showw();


        }
        Form f = null;
        public void showw()
        {

            dtg.DataSource = BLLpeople.instance.getallnv(BLLpeople.instance.Getpidnv());
        }




        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            dtg.DataSource = BLLpeople.instance.searchP(bunifuTextbox1.text);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count == 1)
            {

                string mssv = dtg.SelectedRows[0].Cells["Username"].Value.ToString();

                f.Show();

            }

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtg.SelectedRows)
                {

                    BLLpeople.instance.delperson(row.Cells["Username"].Value.ToString());
                }
            }
            showw();

        }



        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void idcard_Leave_1(object sender, EventArgs e)
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

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if (!BLLpeople.instance.check(txtusername.Text))
            {
                usernamedk.Text = "";

            }
            else
            {
                usernamedk.Text = "Tên đăng nhập đã tồn tại ";

            }
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            if (phone.Text.Length < 10 || phone.Text.Length > 10)
            {
                phonedk.Text = " Số điện thoại có 10-11 số !";
                phone.BackColor = Color.LightCoral;
            }
            else
            {
                phonedk.Text = "";
                phone.BackColor = Color.White;
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

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            if (txtpass.Text.Length < 9)
            {
                passdk.Text = " Mật khẩu phải dài hơn 8 kí tự !";
                txtpass.BackColor = Color.LightCoral;
            }
            else
            {
                passdk.Text = "";
                txtpass.BackColor = Color.White;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được để rỗng !");
            }
            else if (txtpass.Text.Length < 9)
            {
                MessageBox.Show("Mật khẩu phải dài hơn 8 kí tự !");
            }
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text.Length == 0)
            {
                MessageBox.Show("Tên đăng nhập không được để rỗng !");
            }
            if (!BLLpeople.instance.check(txtusername.Text))
            {
                usernamedk.Text = "";

            }
            else
            {
                usernamedk.Text = "Tên đăng nhập đã tồn tại ";

            }
        }


        private void bunifuTextbox1_OnTextChange_1(object sender, EventArgs e)
        {
            dtg.DataSource = BLLpeople.instance.searchP(bunifuTextbox1.text);
        }      

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtusername.Text == "" || txtpass.Text == "" || idcard.Text == "" || gmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin bắt buộc !");
            }
            else if (usernamedk.Text != "")
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
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
                LOGIN l = new LOGIN()
                {
                    State = true,
                    PassWord = txtpass.Text,
                    Username = txtusername.Text,
                };
                BLLpeople.instance.Executenv(s);
                BLLpeople.instance.Execute2(l);
                showw();
                txtname.Text = "";
                male.Checked = false;
                female.Checked = false;
                phone.Text = "";
                address.Text = "";
                gmail.Text = "";
                idcard.Text = "";
                date.Text = DateTime.Now.ToString();
                txtusername.Text = "";
                txtpass.Text = "";
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            if (gmaildkk.Text != "" || idcarddk.Text != "" || txtname.Text == "")
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
                showw();
            }
        }
        private void bunifuTextbox1_Click(object sender, EventArgs e)
        {
            bunifuTextbox1.text = "";
        }

        private void dtg_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtg.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                txtname.Text = row.Cells[1].Value.ToString();
                txtusername.Text = row.Cells[0].Value.ToString();
                txtusername.Enabled = false;
                usernamedk.Enabled = false;
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    male.Checked = true;

                }
                else
                {
                    female.Checked = true;
                }

                gmail.Text = row.Cells[6].Value.ToString();
                phone.Text = row.Cells[7].Value.ToString();
                idcard.Text = row.Cells[5].Value.ToString();
                date.Text = row.Cells[3].Value.ToString();
                address.Text = row.Cells[4].Value.ToString();

            }
        }
    }
}
