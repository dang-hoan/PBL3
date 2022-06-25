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
    public partial class bookve : Form
    {
        public delegate void Mydel(string s);
        public Mydel d { get; set; }
        public int trainid = -1; 
        public string trangthai ="";
        int num;
        decimal? giave;
        Label[] label = new Label[31];
        HandlerMyInterfaces handler2 = new HandlerMyInterfaces(Color.FromArgb(0, 192, 0), Color.FromArgb(0, 170, 0), Color.Green);
        public bookve(int s, string k)
        {
            InitializeComponent();
            trainid = s;
            trangthai = k;
            MessageBox.Show(trangthai);
            intit();
            cbbmave.Text = "A";
            set();
            setcolor();
        }



        public void intit()
        {
            txtnametrain.Enabled = false;
            txtgiave.Enabled = false;
            txtdivername.Enabled = false;
            txtdep.Enabled = false;
            txtdes.Enabled = false;
            timedep.Enabled = false;
            timedes.Enabled = false;
            gettrainid(trainid);

        }
      
        public void set()
        {

          
            int size = 50;
            int X = 60, Y = 210;
            for (int i = 0; i < 30; i++)
            {
                label[i] = new Label();
                if (label[i] == null)
                    MessageBox.Show("null");
                //Tên label
                label[i].Text = (i + 1).ToString();
                label[i].TextAlign = ContentAlignment.MiddleCenter;

                //Kiểu chữ
                label[i].Font = new Font("Arial", 12f, FontStyle.Bold);

                //Kích thước, vị trí
                label[i].Size = new Size(size - 10, size - 10);
                label[i].Location = new Point(X + size * (i % 10), Y + size * (i / 10));

                //Trang trí
                label[i].BorderStyle = BorderStyle.FixedSingle;
                label[i].BackColor = Color.Silver;

                //Xử lý sự kiện
                label[i].Click += new EventHandler(label_Click);
                label[i].BackColor = Color.FromArgb(0, 170, 0);
                label[i].Cursor = Cursors.Hand;

                this.Controls.Add(label[i]);
            }

        }
        public void color(ref Label b, string s)
        {
           if(s=="")
            {
                b.BackColor = Color.FromArgb(0, 170, 0);
            }    


            if ((s == "dadat") && (trangthai == "mua"))
            {
                b.Enabled = false;
                b.BackColor = Color.Red;
            }
            else
            if (s == "dadat")
            {
                b.BackColor = Color.Red;
            }

        }
         
       
    public void setcolor()
        {
            
            foreach (TICKET tic in BLLTicket.instance.getticketbylist(trainid, cbbmave.Text))
            {
                string s = tic.SeatNo;
                s = s.Substring(1);
                int k = int.Parse(s)-1;
                if (tic.Booked == true)
                {  
                    color(ref label[k], "dadat");
                }
                else
                {
                    color(ref label[k], "");
                }    
            }
        }
        private void gettrainid(int trainid)
        {
            int s=-1;
            foreach (TRAIN i in BLLTRAIN.Instance.trainaddve(trainid))
            {
                txtnametrain.Text = i.TrainName;
                num = i.NumberOfCarriages;
                giave = i.BasicPrice;
                txtgiave.Text=giave.ToString();
                txtnametrain.Text = i.TrainName;
                foreach(CBBItem k in BLLpeople.instance.GetCBBname())
                {
                  if(k.Value == i.DriverUN)
                    {
                        txtdivername.Text = k.Text;
                    }    
                }    
                s = i.ScheduleID;
            }
            foreach(SCHEDULE sch in BLLTRAIN.Instance.GetScheduleid(s))
            {
                txtdep.Text = sch.Departure;
                txtdes.Text = sch.Destination;
                timedep.Text = sch.DepartureTime.ToString();
                timedes.Text = sch.ArrivalTime.ToString();
            }    
            for (int i = 1; i <= num; i++)
            {
                cbbmave.Items.Add(Convert.ToChar(i + 64)).ToString();

            }
        }


        private void butcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Click(object sender, EventArgs e)
        { 
            string ghe = ((Label)sender).Text.Trim();
           string seatno = cbbmave.Text+ghe;
            if (trangthai == "mua")
            {
                datve f = new datve(trainid, seatno,"");
                f.Show();
            }
            if (trangthai == "xem")
            {
                datve f = new datve(trainid, seatno,"xem");
                f.Show();
            }

        }
        

        private void cbbmave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbmave.Text != "")
            {
                int sotoa = Convert.ToChar(cbbmave.Text) - 64;
                decimal? gia = Convert.ToDecimal((((sotoa - 1) * 0.1) + 1) * Convert.ToDouble(giave));
                txtgiave.Text = gia.ToString();
            }
            setcolor();
            
        }
    }
}

