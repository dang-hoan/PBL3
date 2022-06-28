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
    public partial class addtrain : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public int trainid, scheduleid;
        public addtrain(int s)
        {
            InitializeComponent();
            if (schedule.Text != "") label1.Visible = false;
            else label1.Visible = true;
            scheduleid = s;
            Init();
            schedule.Enabled = false;
        }
        PBL3 db = new PBL3();
        private void Init()
        {
            cbbName.Items.AddRange(BLLTRAIN.Instance.GetTrain().ToArray());
            SCHEDULE i = BLLTRAIN.Instance.GetScheduleid(scheduleid);
            if(i != null)
            {
                schedule.Text = i.ScheduleID.ToString();
                cbbDep.Text = i.STATION1.StationName;
                cbbDes.Text = i.STATION.StationName;

            }
            schedule.Enabled = false;
            cbbDep.Enabled = false;
            cbbDes.Enabled = false;
            foreach (CBBpeople s in BLLTRAIN.Instance.GetAllCBBDriver())
            {
                cbblaixe.Items.Add(s);
            }
            if (schedule.Text != "") label1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool CheckNum(string money)
        {
            int temp;
            if(!int.TryParse(money, out temp))
            {
                MessageBox.Show("Giá vé cơ bản phải là một số!");
                return false;
            }
            else if (temp <= 0)
            {
                MessageBox.Show("Giá vé cơ bản phải là một số dương!");
                return false;
            }
            return true;
        }
        private void bTOK_Click(object sender, EventArgs e)
        {
            if (schedule.Text == "")
            {
                MessageBox.Show("Chọn một lịch trình trước bấm xác nhận!");
                return;
            }
            if ( (cbbName.Text == "") || (txtsotoa.Text == "") || (cbblaixe.Text == "") || txtgiagoc.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin cho chuyến tàu!");
                return;
            }
            if (!CheckNum(txtgiagoc.Text)) return;
            if (!BLLTRAIN.Instance.CheckTrip(Convert.ToInt32(schedule.Text), Convert.ToInt32(((CBBItem)cbbName.SelectedItem).Value)))
            {
                TRIP s = new TRIP
                {
                    ScheduleID = Convert.ToInt32(schedule.Text),
                    TrainID = Convert.ToInt32(((CBBItem)cbbName.SelectedItem).Value),
                    DriverUN = ((CBBpeople)cbblaixe.SelectedItem).Value,
                    BasicPrice = (decimal)Convert.ToDouble(txtgiagoc.Text)
                };
                BLLTRAIN.Instance.AddTrip(s);
                MessageBox.Show("Đã thêm chuyến tàu thành công!");
                d();
                this.Close();
            }
            else
            {
                MessageBox.Show("Chuyến tàu bạn thêm đã có trong hệ thống!");
            }
           
        }
        private void getScheduleID(int scheduleid)
        {
            label1.Visible = false;
            SCHEDULE i = BLLTRAIN.Instance.GetScheduleid(scheduleid);
            schedule.Text = i.ScheduleID.ToString();
            cbbDep.Text = i.STATION1.StationName;
            cbbDes.Text = i.STATION.StationName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsotoa.Text = BLLTRAIN.Instance.GetNumberOfCarriages(cbbName.Text).ToString();
        }

        private void lich_trinh_Click(object sender, EventArgs e)
        {
            if(schedule.Text == "")
            {
                lichtrinadd f = new lichtrinadd();
                f.Show();
                f.d = new lichtrinadd.MyDel(getScheduleID);
            }
            else MessageBox.Show("da chon lich trinh truoc do!");
        }

     
    }
}
