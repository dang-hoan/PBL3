﻿using System;
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
        public delegate void Mydel(string username);
        public Mydel d;
        private string username;
        public addkhachhang(string s)
        {
            username = s;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            checkBox1.Visible = false;
            if (username != "")
            {
                label15.Text = "CẬP NHẬT THÔNG TIN KHÁCH HÀNG";
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
                if(g != null) txtpass.Text = g.PassWord;

                labBirthDay.Text = "";
                label9.Text = "";
                label11.Text = "";
                label12.Text = "";
                label13.Text = "";
                label14.Text = "";

                if (txtpass.Text == "")
                {
                    checkBox1.Checked = false;
                    checkBox1.Visible = true;
                }
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
        private void butok_Click(object sender, EventArgs e)
        {
            string sa = date.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.AddYears(-15).ToString("yyyy/MM/dd HH:mm");
            if (string.Compare(sa, now) > 0)
            {
                labBirthDay.Text = "*Người dùng tối thiểu phải đủ 15 tuổi!";
            }
            else labBirthDay.Text = "";
            if (labBirthDay.Text != "")
            {
                MessageBox.Show("Bạn nhập thông tin ngày sinh chưa đúng yêu cầu!");
                return;
            }
            if(txtsdt.Text.Length > 9 || txtsdt.Text.Length < 9)
            {
                MessageBox.Show("Số điện thoại phải có 9 chữ số (không tính số 0 ở đầu)!");
                return;
            }
            if(txtidcard.Text.Length > 12 || txtidcard.Text.Length < 12)
            {
                MessageBox.Show("Số CCCD phải có 12 chữ số!");
                return;
            }
            if (!CheckNumber(txtidcard.Text))
            {
                MessageBox.Show("Số CCCD phải là 1 số!");
                return;

            }
            if (BLLTRAIN.Instance.CheckIDCard2(username, txtidcard.Text))
            {
                MessageBox.Show("Số căn cước công dân bạn nhập đã tồn tại trong hệ thống!");
                return;
            }
            if(BLLTRAIN.Instance.CheckPhone(username, "0" + txtsdt.Text))
            {
                MessageBox.Show("Số điện thoại bạn nhập đã tồn tại trong hệ thống!");
                return;

            }
            if (BLLTRAIN.Instance.CheckEmail(username, txtgamil.Text))
            {
                MessageBox.Show("Email bạn nhập đã tồn tại trong hệ thống!");
                return;
            }
            if (!CheckNumber(txtsdt.Text))
            {
                MessageBox.Show("Số điện thoại phải là 1 số!");
                return;
            }
            if ((txtidcard.Text == "") || (txtgamil.Text == "") || (txtsdt.Text == ""))
            {
                MessageBox.Show("Bạn chưa nhập đủ dữ liệu bắt buộc!");
                return;
            }
            if (!txtgamil.Text.Contains("@gmail.com"))
            {
                MessageBox.Show("Email không đúng định dạng!");
                return;
            }
            else
            {
                if ("@gmail.com".IndexOf(txtgamil.Text) != "@gmail.com".LastIndexOf(txtgamil.Text))
                {
                    MessageBox.Show("Email không đúng định dạng!");
                    return;
                }
            };
            if ((txtuser.Text == "" || txtpass.Text == "") && checkBox1.Checked == true)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không thể để trống!");
            }
            else
            {
                if(BLLpeople.instance.check(txtuser.Text) == false)
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
                        IDCard = txtidcard.Text
                    };

                    LOGIN dn = new LOGIN()
                    {
                        Username = txtuser.Text,
                        PassWord = txtpass.Text,
                    };
                    BLLpeople.instance.Execute(s);
                    BLLpeople.instance.Execute2(dn);
                    MessageBox.Show("Đã thêm thành công khách hàng mới!");
                    d("");
                    this.Close();
                }
                else {
                    //bấm button Add (username truyền dô hàm dựng == "") nhưng nhập username đã tồn tại
                    if(username == "") MessageBox.Show("Username bạn nhập đã tồn tại trong hệ thống!"); 
                    //bấm button Update (username truyền dô hàm dựng khác "")
                    else{
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
                        if(checkBox1.Checked == true) BLLpeople.instance.Execute2(dn);
                        MessageBox.Show("Đã cập nhật thành công thông tin khách hàng!");
                        d("");
                        this.Close();
                    }
                }
            }
        }


        private void txtidcard_Leave(object sender, EventArgs e)
        {
            if (txtidcard.Text.Length != 12)
            {
                MessageBox.Show("Căn cước công dân phải có 12 chữ số!");
            };
        }

        private void txtidcard_TextChanged(object sender, EventArgs e)
        {
            if (txtidcard.Text.Length != 12)
            {
                label9.Text = "Nhập chưa đúng 12 chữ số";
            }
            else
            {
                label9.Text = "Đã đủ 12 chữ số";
            }
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            if (txtsdt.Text.Length != 9)
            {
                label11.Text = "Nhập chưa đúng 9 chữ số";
            }
            else
            {
                label11.Text = "Đã đủ 9 chữ số";
            }
        }


        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            if (BLLpeople.instance.check(txtuser.Text))
                label13.Text = "Username đã tồn tại!";
            else label13.Text = "";
        }

        private void buthuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            string s = date.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.AddYears(-15).ToString("yyyy/MM/dd HH:mm");
            if (string.Compare(s, now) > 0)
            {
                labBirthDay.Text = "*Người dùng tối thiểu phải đủ 15 tuổi!";
                return;
            }
            labBirthDay.Text = "";
        }

        private void txtpass_Click(object sender, EventArgs e)
        {
            txtpass.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked) txtpass.Enabled = true;
            else txtpass.Enabled = false;
        }
    }

}