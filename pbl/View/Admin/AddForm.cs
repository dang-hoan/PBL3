using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;

namespace pbl
{
    
    public partial class AddForm : Form
    {
        public delegate void Mydel(string usern);
        public Mydel d;
        public string usern{ get; set; }
        public AddForm(string s)
        {
            usern = s;
            InitializeComponent();
           
            GUI();
        }
        
        public void GUI()
        {
            if (BLLpeople.instance.check(usern))
            {
                txtusername.Text = BLLpeople.instance.GetuserByusername(usern).Username.ToString();
                bool check = Convert.ToBoolean(BLLpeople.instance.GetuserByusername(usern).Gender);
                txtusername.Enabled = false;
                txtname.Text = BLLpeople.instance.GetuserByusername(usern).Name.ToString();
                date.Value = Convert.ToDateTime(BLLpeople.instance.GetuserByusername(usern).BirthDay);
                address.Text = BLLpeople.instance.GetuserByusername(usern).Address.ToString();
                gmail.Text = BLLpeople.instance.GetuserByusername(usern).Email.ToString();
                idcard.Text = BLLpeople.instance.GetuserByusername(usern).IDCard.ToString();
                positionid.Text = BLLpeople.instance.GetuserByusername(usern).PositionID.ToString();
                phone.Text = BLLpeople.instance.GetuserByusername(usern).Phone.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PEOPLE s = new PEOPLE()
            {
                Username =txtusername.Text,
                Name = txtname.Text,
                Gender = (male.Checked == true) ? true : false,
                BirthDay = date.Value,
                Phone = phone.Text,
                Address = address.Text,
                Email = gmail.Text,
                IDCard = idcard.Text,
                PositionID=positionid.Text,
            };
            BLLpeople.instance.Execute(s);
            
            d("");

            this.Close();

        }

       
    }
}
