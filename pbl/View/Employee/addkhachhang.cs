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
        string user;
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
                txtuser.Text = p.Username.ToString();
                txtuser.Enabled = false;
                txtname.Text = p.Name.ToString();
                date.Value = Convert.ToDateTime(BLLpeople.instance.GetuserByusername(username).BirthDay);
                txtdiachi.Text = p.Address.ToString();
                txtgamil.Text = p.Email.ToString();
                txtidcard.Text = p.IDCard.ToString();
               
            }
        }
    private void butok_Click(object sender, EventArgs e)
        {
            if (user == txtuser.Text)
            {
                PEOPLE s = new PEOPLE
                {

                    Username = txtuser.Text,
                    Name = txtname.Text,
                    Gender = (rdinam.Checked == true) ? true : false,
                    BirthDay = date.Value,
                    Phone = txtsdt.Text,
                    Address = txtdiachi.Text,
                    Email = txtgamil.Text,
                    IDCard = txtidcard.Text,
                    PositionID = "124"
                };

                LOGIN dn = new LOGIN()
                {
                    Username = txtuser.Text,
                    PassWord = txtpass.Text,
                };
                BLLpeople.instance.Execute(s);

                BLLpeople.instance.Execute2(dn);
            }
            else
            if (BLLpeople.instance.check(txtuser.Text))
            {
                PEOPLE s = new PEOPLE
                { 

                    Username = txtuser.Text,
                    Name = txtname.Text,
                    Gender = (rdinam.Checked == true) ? true : false,
                    BirthDay = date.Value,
                    Phone = txtsdt.Text,
                    Address = txtdiachi.Text,
                    Email = txtgamil.Text,
                    IDCard = txtidcard.Text,
                    PositionID ="124"
                };
               
                LOGIN dn = new LOGIN()
                {   
                            Username=txtuser.Text,
                            PassWord = txtpass.Text,
                };
                BLLpeople.instance.Execute(s);

                    BLLpeople.instance.Execute2(dn);
            }
 ;
            d("");
            this.Close();
        }

        private void buthuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}