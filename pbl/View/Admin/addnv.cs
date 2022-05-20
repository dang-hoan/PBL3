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
        /*public delegate void Mydel(string usern);
        public Mydel d;
        public string usern { get; set; }*/
        public addnv()
        {
            
            InitializeComponent();
            shownv();
            
        }
        public void shownv()
        {
            
            dtgaddnv.DataSource = BLLpeople.instance.getallnv("222");
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
            string p = " ";
            if (positionid.Text == "Nhân viên")
            {
                p = "222";
            }
            else if (positionid.Text == "Giám đốc")
            {
                p = "111";
            }
            else if (positionid.Text == "Khách hàng")
            {
                p = "333";
            }
           // if(usern == txtname.Text)
           // {

//}
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
                PositionID = p,
            };
            LOGIN l = new LOGIN()
            {
                IDlogin = 100,
                PassWord = txtpass.Text,
                Username = txtusername.Text,
            };
            BLLpeople.instance.Execute(s);
            BLLpeople.instance.Execute2(l);
            shownv();
           // d("");

            this.Close();
        }
    }
}
