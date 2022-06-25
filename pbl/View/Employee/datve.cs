using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.DTO;
using pbl.BLL;

namespace pbl.View
{
    public partial class datve : Form
    {

        public delegate void mydel();
        public mydel d;
        int matau { get; set; }
        string vitri { get; set; }
        string trangthai { get; set; }


        public datve(int trainid, string seatno,string s)
        {
            InitializeComponent();
            matau = trainid;
            vitri = seatno;
            trangthai = s;
            init();
        }
        public void init()
        {
            if (trangthai == "xem")
            {
                foreach (TICKET i in BLLTicket.instance.getticketbylist(matau, vitri))
                {
                    if (i.Booked ==true)
                    {
                        foreach (PEOPLE_View peo in BLLpeople.instance.GetPPByUsername(i.CustomerUN))
                        {
                            txtemail.Text = peo.Email;
                            txtidcard.Text = peo.IDCard;
                            txtname.Text = peo.Name;
                            txtsdt.Text = peo.Phone;
                        }
                    }
                };
                txtemail.Enabled = false;
                txtidcard.Enabled = false;
                txtname.Enabled = false;
                txtsdt.Enabled = false;
            }
           

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (BLLpeople.instance.check(txtidcard.Text))
            {
                PEOPLE p = new PEOPLE
                { Phone = txtsdt.Text,
                    Email = txtemail.Text,
                    Name = txtname.Text,
                    IDCard = txtidcard.Text,
                    Username = txtidcard.Text,
                };
                BLLpeople.instance.Execute(p);
            }
            TICKET tic = new TICKET
            {
                TrainID = matau,
                SeatNo = vitri,
                CustomerUN = txtidcard.Text,
                Booked = true
            };
            BLLTRAIN.Instance.addticket(tic);
            
        }
    }
}
