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
    public partial class GUIBook : Form
    {
        public delegate void Mydel(string s);
        public Mydel d { get; set; }
        public int scheduleid = -1; 
        public string trangthai ="";
        int num;
        decimal? giave;
        Label[] label = new Label[31];
        HandlerMyInterfaces handler2 = new HandlerMyInterfaces(Color.FromArgb(0, 192, 0), Color.FromArgb(0, 170, 0), Color.Green);
        public GUIBook(int s)
        {
            InitializeComponent();
            scheduleid = s;
            set();
            intit();
            setcolor();
        }



        public void intit()
        {
            txtgiave.Enabled = false;
            txtdivername.Enabled = false;
            txtdep.Enabled = false;
            txtdes.Enabled = false;
            timedep.Enabled = false;
            timedes.Enabled = false;
            gettrainid(scheduleid);

        }
      
        public void set()
        {
            int size = 50;
            int X = 60, Y = 210;
            for (int i = 0; i < 30; i++)
            {
                label[i] = new Label();
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
            if (s=="")
            {
                b.BackColor = Color.FromArgb(0, 170, 0);
                b.Cursor = Cursors.Hand;
            }
            else
            {
                b.BackColor = Color.Red;
                b.Cursor = Cursors.Default;
            }

        }
         
       
    public void setcolor()
        {
            foreach (TICKET tic in BLLTicket.instance.getticketbylist(scheduleid, ((CBBItem)(cbbnametrain.SelectedItem)).Value, cbbmave.Text))
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
        private void gettrainid(int scheduleid)
        {
            cbbnametrain.Items.AddRange(BLLTRAIN.Instance.GetTrain(scheduleid).ToArray());
            cbbnametrain.SelectedIndex = 0;
            for (int j = 1; j <= num; j++)
            {
                cbbmave.Items.Add(Convert.ToChar(j + 64)).ToString();
            }
            cbbmave.SelectedIndex = 0;
        }


        private void butcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Click(object sender, EventArgs e)
        { 
            string ghe = ((Label)sender).Text.Trim();
            string seatno = cbbmave.Text+ghe;
            TICKET tic = new TICKET
            {
                ScheduleID = scheduleid,
                TrainID = ((CBBItem)(cbbnametrain.SelectedItem)).Value,
                SeatNo = seatno,
                CustomerUN = GUILogin.userName,
                Booked = true
            };
            if (((Label)sender).BackColor == Color.Red)
            {
                if (BLLTRAIN.Instance.CheckTicket(tic)){
                    MessageNotice note = new MessageNotice("Vé này bạn đã đặt!", "Thông báo", "Đồng ý", "Huỷ vé", tic);
                    note.Show();
                    note.d += new MessageNotice.MyDel(setcolor);
                }
                else MessageBox.Show("Vé này đã có người đặt!");
                return;
            }
            BLLTRAIN.Instance.addticket(tic);
            MessageBox.Show("Đã đặt vé thành công!");
            setcolor();
        }

        private void cbbnametrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            TRIP i = BLLTRAIN.Instance.GetTrip(scheduleid, ((CBBItem)(cbbnametrain.SelectedItem)).Value);
            if (i != null)
            {
                cbbnametrain.Text = i.TRAIN.TrainName;
                num = i.TRAIN.NumberOfCarriages;
                giave = i.BasicPrice;
                foreach (CBBpeople k in BLLpeople.instance.GetCBBname())
                {
                    if (k.Value == i.DriverUN)
                    {
                        txtdivername.Text = k.Text;
                    }
                }
                txtdep.Text = i.SCHEDULE.STATION1.StationName;
                txtdes.Text = i.SCHEDULE.STATION.StationName;
                timedep.Text = i.SCHEDULE.DepartureTime.ToString("dd/MM/yyyy HH:mm");
                timedes.Text = i.SCHEDULE.ArrivalTime.ToString("dd/MM/yyyy HH:mm");
            }
            setcolor();
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

