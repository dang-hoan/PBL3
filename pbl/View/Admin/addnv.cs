﻿using pbl.BLL;
using pbl.DTO;
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
    public partial class addnv : Form
    {

        public addnv()
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
            if (txtname.Text == "" || txtusername.Text == "" || txtpass.Text == "" || idcard.Text == "" || gmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin bắt buộc !");
            }
            else if ( usernamedk.Text != "")
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
                    State = "Đang làm",
                    PassWord = txtpass.Text,
                    Username = txtusername.Text,
                };
                BLLpeople.instance.Executenv(s);
                BLLpeople.instance.Execute2(l);
                shownv();
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

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if(!BLLpeople.instance.check(txtusername.Text))
            {
                usernamedk.Text = "";

            }
            else
            {
                usernamedk.Text = "Tên đăng nhập đã tồn tại ";

            }
        }
    }
}
