using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;
using pbl.DTO;

namespace pbl.View
{
    public partial class addkhachhang : Form
    {
        string user, pass;
        public delegate void Mydel(string username);
        public Mydel d;
        public string username { get; set; }
        public addkhachhang(string s)
        {
            username = s;
            InitializeComponent();
            GUI();
            user = username;
        }
        public void GUI()
        {
            if (BLLpeople.instance.check(username))
            {
                PEOPLE p = BLLpeople.instance.GetuserByusername(username);
                txtuser.Text = p.Username;
                txtuser.Enabled = false;
                txtname.Text = p.Name;
                if (p.Gender == true) rdinam.Checked = true;
                else rdinu.Checked = true;
                date.Text = p.BirthDay.ToString();
                txtsdt.Text = p.Phone.Remove(0, 1);
                txtdiachi.Text = p.Address;
                txtgamil.Text = p.Email;
                txtidcard.Text = p.IDCard;
                LOGIN g = BLLpeople.instance.Getloginbyloginid(username);
                txtpass.Text = g.PassWord;
                pass = txtpass.Text;
            }
        }
        private void butok_Click(object sender, EventArgs e)
        {
            if ((txtidcard.Text == "") || (txtname.Text == "") || (txtsdt.Text == "") || (txtuser.Text == ""))
            {
                MessageBox.Show("bạn chưa nhập đủ dữ liệu bắt buộc ");
            }

            else
            {
                if (user == txtuser.Text)
                {
                    MessageBox.Show("..");
                    PEOPLE s = new PEOPLE
                    {

                        Username = txtuser.Text,
                        Name = txtname.Text,
                        Gender = (rdinam.Checked == true) ? true : false,
                        BirthDay = date.Value,
                        Phone = "0" + txtsdt.Text,
                        Address = txtdiachi.Text,
                        Email = txtgamil.Text,
                        IDCard = txtidcard.Text
                    };

                    LOGIN dn = new LOGIN()
                    {
                        Username = txtuser.Text,
                        PassWord = txtpass.Text,
                    };
                    BLLpeople.instance.Execute(s);
                    if (pass != txtpass.Text)
                    {
                        BLLpeople.instance.Execute2(dn);
                        MessageBox.Show("ban da doi mk thanh cong !");
                    }
                    d("");
                    this.Close();
                }
                else
                    if (BLLpeople.instance.check(txtuser.Text))
                    MessageBox.Show("username của không hợp lệ ");
                else
                {
                    PEOPLE s = new PEOPLE
                    {

                        Username = txtuser.Text,
                        Name = txtname.Text,
                        Gender = (rdinam.Checked == true) ? true : false,
                        BirthDay = date.Value,
                        Phone = "0" + txtsdt.Text,
                        Address = txtdiachi.Text,
                        Email = txtgamil.Text,
                        IDCard = txtidcard.Text,
                        PositionID = 124
                    };

                    LOGIN dn = new LOGIN()
                    {
                        Username = txtuser.Text,
                        PassWord = txtpass.Text,
                    };
                    BLLpeople.instance.Execute(s);
                    BLLpeople.instance.Execute2(dn);
                    d("");
                    this.Close();
                };

            }
        }


        private void txtidcard_Leave(object sender, EventArgs e)
        {
            if (txtidcard.Text.Length != 12)
            {
                MessageBox.Show("id card chi duoc dung 12 chu so ");
            };
        }

        private void txtidcard_TextChanged(object sender, EventArgs e)
        {
            if (txtidcard.Text.Length != 12)
            {
                label9.Text = "nhap chua du 12 chu so ";
            }
            else
            {
                label9.Text = "nhap da du  12 chu so ";
            }
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtuser_TextChanged(object sender, EventArgs e)
        {

            if (!(BLLpeople.instance.check(txtuser.Text)))
                label13.Text = ("username hợp lệ ");
            else
                if (BLLpeople.instance.check(user))
                label13.Text = ("username không hợp lệ ");
        }

        private void buthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtpass.Text = "";
        }
    }

}