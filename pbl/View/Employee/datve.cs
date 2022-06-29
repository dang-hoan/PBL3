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
        int malichtrinh { get; set; }
        int matau { get; set; }
        string vitri { get; set; }
        string trangthai { get; set; }


        public datve(int scheduleid, int trainid, string seatno,string s)
        {
            InitializeComponent();
            malichtrinh = scheduleid;
            matau = trainid;
            vitri = seatno;
            trangthai = s;
            init();
        }
        public void init()
        {
            if (trangthai == "xem")
            {
                foreach (TICKET i in BLLTicket.instance.getticketbylist(malichtrinh,matau, vitri))
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
                button1.Visible = false;
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
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "" || txtidcard.Text == "" || txtemail.Text == "" || txtsdt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin cho khách hàng!");
                return;
            }
            if (!CheckNumber(txtidcard.Text))
            {
                MessageBox.Show("Số căn cước công dân phải có dạng số!");
                return;
            }
            if (txtidcard.Text.Length > 12)
            {
                MessageBox.Show("Số căn cước công dân chỉ có 12 chữ số!");
                return;
            }
            if (txtidcard.Text.Length < 12)
            {
                MessageBox.Show("Số căn cước công dân phải đủ 12 chữ số!");
                return;
            }
            if (!CheckNumber(txtsdt.Text))
            {
                MessageBox.Show("Số điện thoại phải có dạng số!");
                return;
            }
            if (txtsdt.Text.Length > 10)
            {
                MessageBox.Show("*Số điện thoại chỉ có 10 chữ số!");
                return;
            }
            else if (txtsdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 chữ số!");
                return;
            }
            if (!BLLpeople.instance.check(txtidcard.Text))
            {
                PEOPLE p = new PEOPLE
                {   Phone = txtsdt.Text,
                    Email = txtemail.Text,
                    Name = txtname.Text,
                    IDCard = txtidcard.Text,
                    Username = txtidcard.Text,
                };
                BLLpeople.instance.Execute(p);
            }
            TICKET tic = new TICKET
            {
                ScheduleID = malichtrinh,
                TrainID = matau,
                SeatNo = vitri,
                CustomerUN = txtidcard.Text,
                Booked = true
            };
            BLLTRAIN.Instance.addticket(tic);
            MessageBox.Show("Đã đặt vé thành công cho khách hàng " + txtname.Text + "!");
            d();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
