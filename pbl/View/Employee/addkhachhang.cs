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
        public delegate void Mydel(string username);
        public Mydel d;
        public string username { get; set; }
        public addkhachhang(string s)
        {
            username = s;
            InitializeComponent();
            GUI();
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
            PEOPLE s = new PEOPLE()
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
            BLLpeople.instance.Execute(s);
            d("");
            this.Close();
        }

        private void buthuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}