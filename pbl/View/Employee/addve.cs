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
using pbl.DTO;

namespace pbl.View
{
    public partial class addve : Form
    {
        public delegate void Mydel(string s);
        public Mydel d { get; set; }
        public int trainid = -1, scheduleid = -1;
        int kiemtra = -1;
        int num;
        decimal? giave;
        public addve(int s)
        {
            InitializeComponent();
            trainid = s;
            kiemtra=s;
            GUI();
            intit();

        }
        public void thamchieu(string trainid)
        {
            txttrainid.Text = trainid;
        }
        public void intit()
        {
            gettrainid(trainid);
            //foreach (TRAIN i in BLLTRAIN.Instance.trainaddve(int.Parse(trainid)))
            //{
            //    txttrainid.Text = i.TrainID.ToString();
            //    txtname.Text = i.TrainName;
            //    txtschedule.Text = i.ScheduleID;
            //    txtsotau.Text = i.NumberOfCarriages.ToString();

            //}
            txtschedule.Enabled = false;
                txttrainid.Enabled = false;
                txtname.Enabled = false;
                txtsotau.Enabled = false;
            
        }
        public void GUI()
        { 
            for (int i = 1; i <= 25; i++)
            {
                cbbseat.Items.Add(i.ToString());
            }
          

        }
        private void gettrainid(int trainid)
        {
            if(txtschedule.Text != "") label2.Visible = false;
            else label2.Visible = true;
            foreach (TRAIN i in BLLTRAIN.Instance.trainaddve(trainid))
            {
                txtschedule.Text = i.ScheduleID.ToString();
                txttrainid.Text = i.TrainID.ToString();
                txtname.Text = i.TrainName;
                txtsotau.Text = i.NumberOfCarriages.ToString();
                num = i.NumberOfCarriages;
                giave = i.BasicPrice;
             
            }
            for (int i = 1; i <= num; i++)
            {
                cbbmave.Items.Add(Convert.ToChar(i+64)).ToString();
                
            }
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            if (txttrainid.Text == "")
            {
                MessageBox.Show("chon mot chuyen tau truoc khi ok!");
                return;
            }
            if ( (cbbseat.Text == "") || (cbbmave.Text == ""))
            {
                MessageBox.Show("bạn chưa nhập đủ dư liệu bắt buộc ");
                return;
            }
            else
            {
                if (BLLTRAIN.Instance.checkseat(Convert.ToInt32(txtschedule.Text), cbbmave.Text + cbbseat.Text, Convert.ToInt32(txttrainid.Text)))
                {
                    MessageBox.Show(" Đã có vé trong hệ thông ");
                    return;
                }
                TICKET s = new TICKET
                {
                    TrainID = int.Parse(txttrainid.Text),
                    SeatNo = cbbmave.Text + cbbseat.Text,
                    TicketPrice = decimal.Parse(txtgiave.Text),
                    Booked = false

                };
                BLLTicket.instance.Execute(s);
                d("");
                this.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addve_Load(object sender, EventArgs e)
        {

        }

        private void pChat_Click(object sender, EventArgs e)
        {
            if (txttrainid.Text == "")
            {
                trainve f = new trainve();
                f.Show();
                f.d = new trainve.mydel(gettrainid);
            }
            else MessageBox.Show("da chon chuyen tau truoc do!");
        }

        private void cbbseat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbmave_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A1 B2 =>string
            if (cbbmave.Text != "")
            {               
                int sotoa = Convert.ToChar(cbbmave.Text) - 64;
                decimal? gia = Convert.ToDecimal((((sotoa - 1) * 0.1) + 1) * Convert.ToDouble(giave));
                txtgiave.Text = gia.ToString();
            }  
        }
    }
}
