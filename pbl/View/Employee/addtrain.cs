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
            trainid = s;
            Init();
            schedule.Enabled = false;
            cbbDep.Enabled = false;
            cbbDes.Enabled = false;
        }
        PBL3 db = new PBL3();
        private void Init()
        {
            cbbName.Items.AddRange(BLLTRAIN.Instance.GetTrain().ToArray());
            foreach (SCHEDULE i in BLLTRAIN.Instance.GetScheduleid(trainid))
            {
                schedule.Text = i.ScheduleID.ToString();
                schedule.Enabled = false;
                cbbDep.Text = i.STATION.StationName;
                cbbDep.Enabled = false;
                cbbDes.Text = i.STATION1.StationName;
                cbbDes.Enabled = false;
            }
            List<string> name = new List<string>();
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

        private void bTOK_Click(object sender, EventArgs e)
        {
            if (schedule.Text == "")
            {
                MessageBox.Show("chon mot lich trinh truoc khi ok!");
            }
            if ( (cbbName.Text == "") || (txtsotoa.Text == "") || (cbblaixe.Text == "")||(schedule.Text==""))
            {
                MessageBox.Show("bạn chưa nhập đủ dư liệu bắt buộc ");
            }
            else
            {
                TRIP s = new TRIP
                {
                    ScheduleID = Convert.ToInt32(schedule.Text),
                    TrainID = Convert.ToInt32(((CBBItem)cbbName.SelectedItem).Value),
                    DriverUN = ((CBBpeople)cbblaixe.SelectedItem).Value,
                    BasicPrice = (decimal)Convert.ToDouble(txtgiagoc.Text)
                };
                BLLTRAIN.Instance.Executetrip(s);
                d();
                this.Close();
                BLLTRAIN.Instance.AddListTicket(s);
            }

           
        }
        private void getScheduleID(int scheduleid)
        {
            label1.Visible = false;
            foreach (SCHEDULE i in BLLTRAIN.Instance.GetScheduleid(scheduleid))
            {
                schedule.Text = i.ScheduleID.ToString();
                cbbDep.Text = i.STATION.StationName;
                cbbDes.Text = i.STATION1.StationName;
            }
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
