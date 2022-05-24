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
        string trainid ="";
        public addtrain(string s)
        {
            InitializeComponent();
            trainid = s;
            Init();
            schedule.Enabled = false;
            cbbDep.Enabled = false;
            cbbDes.Enabled = false;
        }
        PBL3 db = new PBL3();
        private void Init()
        {
            foreach (SCHEDULE i in BLLTRAIN.Instance.GetScheduleid(trainid))
            {
                schedule.Text = i.ScheduleID;
                schedule.Enabled = false;
                cbbDep.Text = i.Departure;
                cbbDep.Enabled = false;
                cbbDes.Text = i.Destination;
                cbbDes.Enabled = false;
            }
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
            if (trainid == "")
            {
                MessageBox.Show("chon mot lich trinh truoc khi ok!");
            }

            if ((txtid.Text == "") || (txtname.Text == "") || (txtsotoa.Text == "") || (txtlaixe.Text == "")||(schedule.Text==""))
            {
                MessageBox.Show("bạn chưa nhập đủ dư liệu bắt buộc ");
            }
            else
            {
                TRAIN s = new TRAIN
                {

                    ScheduleID = schedule.Text,
                    TrainName = txtname.Text,
                    TrainID = txtid.Text,
                    NumberOfCarriages = int.Parse(txtsotoa.Text),
                    DriverUN = txtlaixe.Text,

                };
                BLLTRAIN.Instance.Executetrain(s);
                MessageBox.Show("OK");
                d();
                this.Close();
            }

           
        }

        private void lich_trinh_Click(object sender, EventArgs e)
        {
            if (trainid == "")
            {
                lichtrinadd f = new lichtrinadd();
                f.Show();
            }
            else MessageBox.Show("da chon lich trinh truoc do!");
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (!(BLLTRAIN.Instance.checktrain(txtid.Text)))
                txtid.ForeColor = Color.Red;
        }
    }
}
