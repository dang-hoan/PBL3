using pbl.BLL;
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
        public delegate void Mydel(string usern);
        public Mydel d;
        public string usern { get; set; }
        public addnv()
        {

            InitializeComponent();
            shownv();

        }
        public void shownv()
        {

            dtgaddnv.DataSource = BLLpeople.instance.getallnv(222);
        }
        /*public void GUI()
        {
            if (BLLpeople.instance.check(usern))
            {
                PEOPLE p = BLLpeople.instance.GetuserByusername(usern);
                txtusername.Text = p.Username;
                
                txtusername.Enabled = false;
                txtname.Text = p.Name;
                date.Text = p.BirthDay.ToString();
                address.Text = p.Address;
                gmail.Text = p.Email;
                if(p.Gender == true ) male.Checked = true;
                else female.Checked = true;
                idcard.Text = p.IDCard;
                positionid.Text = p.PositionID;
                phone.Text = p.Phone;
            }
        }*/
        private void btok_Click(object sender, EventArgs e)
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
                PositionID = 222,
            };
            LOGIN l = new LOGIN()
            {

                PassWord = txtpass.Text,
                Username = txtusername.Text,
            };
            BLLpeople.instance.Execute(s);
            BLLpeople.instance.Execute2(l);
            shownv();
            //d("");

            //this.Close();
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
            if(txtpass.Text.Length == 0)
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

        
    }
}
