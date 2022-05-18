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

namespace pbl.View
{
    public partial class addlichtrinh : Form
    {
        public delegate void Mydel(string scheduleid);
        public Mydel d;
        string scheduleid;
        public addlichtrinh(string s)
        {
            scheduleid = s;
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
           
                //Schedule p = BLLTRAIN.Instance.Get(username);
                //txtuser.Text = p.Username.ToString();
                //txtuser.Enabled = false;
                //txtname.Text = p.Name.ToString();
                //date.Value = Convert.ToDateTime(BLLpeople.instance.GetuserByusername(username).BirthDay);
                //txtdiachi.Text = p.Address.ToString();
                //txtgamil.Text = p.Email.ToString();
                //txtidcard.Text = p.IDCard.ToString();
           
        }

        private void bTOK_Click(object sender, EventArgs e)
        {
            //PEOPLE s = new PEOPLE()
            ////{
            ////    Username = txtuser.Text,
            ////    Name = txtname.Text,
            ////    Gender = (rdinam.Checked == true) ? true : false,
            ////    BirthDay = date.Value,
            ////    Phone = txtsdt.Text,
            ////    Address = txtdiachi.Text,
            ////    Email = txtgamil.Text,
            ////    IDCard = txtidcard.Text,
            ////    PositionID = "124"
            //};
            //BLLpeople.instance.Execute(s);
            //d("");
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
