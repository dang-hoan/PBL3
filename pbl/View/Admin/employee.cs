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


namespace pbl.View.Admin
{


    public partial class employee : Form
    {
        int dk = 1;
        public employee()
        {

            InitializeComponent();
            showw();
        }
        Form f = null;
        public void showw()
        {

            dtg.DataSource = BLLpeople.instance.getallnsv(BLLpeople.instance.Getpidnv());
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

        private void phone_TextChanged(object sender, EventArgs e)
        {
            if (phone.Text.Length < 10 || phone.Text.Length > 10)
            {
                phonedk.Text = " Số điện thoại phải có 10 chữ số !";
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
      

        private void bunifuTextbox1_OnTextChange_1(object sender, EventArgs e)
        {
            dtg.DataSource = BLLpeople.instance.searchP(bunifuTextbox1.text);
        }      

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            /* Add add = new Add();
             add.Show();*/

            if (gmaildkk.Text != "" || idcarddk.Text != "" || phone.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin bắt buộc!");
            }
            string sa = date.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.AddYears(-15).ToString("yyyy/MM/dd HH:mm");
            if (string.Compare(sa, now) > 0)
            {
                MessageBox.Show("Người dùng tối thiểu phải đủ 15 tuổi!");
                return;
            }
            if (phone.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số!");
                return;
            }
            if (idcard.Text.Length != 12)
            {
                MessageBox.Show("Số CCCD phải có 12 chữ số!");
                return;
            }
            if (!CheckNumber(idcard.Text))
            {
                MessageBox.Show("Số CCCD phải là 1 số!");
                return;

            }
            if (BLLTRAIN.Instance.CheckIDCard2(txtusername.Text, idcard.Text))
            {
                MessageBox.Show("Số căn cước công dân bạn nhập đã tồn tại trong hệ thống!");
                return;
            }
            if (BLLTRAIN.Instance.CheckPhone(txtusername.Text, phone.Text))
            {
                MessageBox.Show("Số điện thoại bạn nhập đã tồn tại trong hệ thống!");
                return;

            }
            if (BLLTRAIN.Instance.CheckEmail(txtusername.Text, gmail.Text))
            {
                MessageBox.Show("Email bạn nhập đã tồn tại trong hệ thống!");
                return;
            }
            if (!CheckNumber(phone.Text))
            {
                MessageBox.Show("Số điện thoại phải là 1 số!");
                return;
            }
            if (!gmail.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Email không đúng định dạng!");
                return;
            }
            else
            {
                if ("@gmail.com".IndexOf(gmail.Text) != "@gmail.com".LastIndexOf(gmail.Text))
                {
                    MessageBox.Show("Email không đúng định dạng!");
                    return;
                }
            }
            if (BLLpeople.instance.check(txtusername.Text) == false)
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
                LOGIN dn = new LOGIN()
                {
                    Username = txtusername.Text,
                    PassWord = txtpass.Text,
                };
              //  BLLpeople.instance.Execute(s);
                BLLpeople.instance.Execute2(dn);
                showw();
                MessageBox.Show("Đã thêm thành công khách hàng mới!");
                reset();

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
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            

                if (gmaildkk.Text != "" || idcarddk.Text != "" || phone.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin bắt buộc!");
                }
                string sa = date.Value.ToString("yyyy/MM/dd HH:mm");
                string now = DateTime.Now.AddYears(-15).ToString("yyyy/MM/dd HH:mm");
                if (string.Compare(sa, now) > 0)
                {
                    MessageBox.Show("Người dùng tối thiểu phải đủ 15 tuổi!");
                    return;
                }
                if (phone.Text.Length != 10)
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số!");
                    return;
                }
                if (idcard.Text.Length != 12)
                {
                    MessageBox.Show("Số CCCD phải có 12 chữ số!");
                    return;
                }
                if (!CheckNumber(idcard.Text))
                {
                    MessageBox.Show("Số CCCD phải là 1 số!");
                    return;

                }
                if (BLLTRAIN.Instance.CheckIDCard2(txtusername.Text, idcard.Text))
                {
                    MessageBox.Show("Số căn cước công dân bạn nhập đã tồn tại trong hệ thống!");
                    return;
                }
                if (BLLTRAIN.Instance.CheckPhone(txtusername.Text, phone.Text))
                {
                    MessageBox.Show("Số điện thoại bạn nhập đã tồn tại trong hệ thống!");
                    return;

                }
                if (BLLTRAIN.Instance.CheckEmail(txtusername.Text, gmail.Text))
                {
                    MessageBox.Show("Email bạn nhập đã tồn tại trong hệ thống!");
                    return;
                }
                if (!CheckNumber(phone.Text))
                {
                    MessageBox.Show("Số điện thoại phải là 1 số!");
                    return;
                }
                if (!gmail.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Email không đúng định dạng!");
                    return;
                }
                else
                {
                    if ("@gmail.com".IndexOf(gmail.Text) != "@gmail.com".LastIndexOf(gmail.Text))
                    {
                        MessageBox.Show("Email không đúng định dạng!");
                        return;
                    }
                }
            if (txtpass.Text == "")
            {
                MessageBox.Show("Mật khẩu không thể để trống!");
            }
            else
            {
                if (BLLpeople.instance.check(txtusername.Text) == true)
                {


                    if (dtg.SelectedRows.Count == 1)
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
                        MessageBox.Show("Đã cập nhật thành công thông tin nhân viên!");
                        showw();
                        reset();
                    }
                }
            }



            
        }
        public void reset()
        {
            txtusername.Text = "";
            txtname.Text = "";
            female.Checked = false;
            male.Checked =false;
            date.Value=DateTime.Now;
            phone.Text = "";
            address.Text = "";
            gmail.Text = "";
            idcard.Text = "";
            txtusername.Enabled = true;
            gmaildkk.Text = "";
            phonedk.Text = "";
            idcarddk.Text = "";
            idcard.BackColor = Color.White;
            phone.BackColor = Color.White;
            txtpass.Text = "";
            txtpass.BackColor = Color.White;

        }
        private void bunifuTextbox1_Click(object sender, EventArgs e)
        {
            bunifuTextbox1.text = "";
        }

        private void dtg_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //k thể lấy mật khẩu
            //DataGridViewRow row = this.dtg.Rows[e.RowIndex];
            //if (e.RowIndex >= 0)
            //{
            //    txtname.Text = row.Cells[1].Value.ToString();
            //    txtusername.Text = row.Cells[0].Value.ToString();
            //    txtusername.Enabled = false;
            //    usernamedk.Enabled = false;
            //    if (row.Cells[2].Value.ToString() == "Nam")
            //    {
            //        male.Checked = true;

            //    }
            //    else
            //    {
            //        female.Checked = true;
            //    }

            //    gmail.Text = row.Cells[6].Value.ToString();
            //    phone.Text = row.Cells[7].Value.ToString();
            //    idcard.Text = row.Cells[5].Value.ToString();
            //    date.Text = row.Cells[3].Value.ToString();
            //    address.Text = row.Cells[4].Value.ToString();

            //}
            dk = 0;
            if(dtg.SelectedRows.Count > 0)
            {
                PEOPLE peo = BLLTRAIN.Instance.GetuserByusername(dtg.SelectedRows[0].Cells[0].Value.ToString());
                txtname.Text = peo.Name;
                txtusername.Text = peo.Username;
                txtusername.Enabled = false;
                label13.Text= "";
                if ((bool)peo.Gender)
                {
                    male.Checked = true;

                }
                else
                {
                    female.Checked = true;
                }

                gmail.Text = peo.Email;
                phone.Text = peo.Phone;
                idcard.Text = peo.IDCard;
                date.Text = peo.BirthDay.ToString();
                address.Text = peo.Address;
                LOGIN g = BLLpeople.instance.Getloginbyloginid(peo.Username);
                if (g != null) txtpass.Text = g.PassWord;
            }
            
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if(dk==1)
            {
                if (BLLpeople.instance.check(txtusername.Text))
                    label13.Text = "Username đã tồn tại!";
                else label13.Text = "";
            }

        }
    }
}
