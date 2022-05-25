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
    public partial class train : Form
    {
     
        public train()
        {
            InitializeComponent();
            gui();
        }
        public void gui()
        {
            List<string> listDep = new List<string>();
            List<string> listDes = new List<string>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach (string s in listDep.Distinct())
            {
                cbbDep.Items.Add(s);
            }
            foreach (string s in listDes.Distinct())
            {
                cbbDes.Items.Add(s);
            }
          

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string DepTime, DesTime;
            DateTime dep, des;

            //DepTime = dateDep.Value.ToString("d/M/yyyy");
            //if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            //{
            //    DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            //}

                SCHEDULE_View s = new SCHEDULE_View()
                {
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                    //DepartureTime = DepTime,
                };
                string scheduleid = "";
                foreach (SCHEDULE_View i in BLLTRAIN.Instance.GetSchedule2(s))
                {
                    scheduleid = i.ScheduleID;
                    MessageBox.Show(scheduleid);
                }
               dataGridView1.DataSource = BLLTRAIN.Instance.GetTrain2(scheduleid);
       

        }

        private void buttrain_Click(object sender, EventArgs e)
        {
            addtrain f = new addtrain("");
            f.Show();
            f.d = new addtrain.Mydel(show);

        }

        private void butall_Click(object sender, EventArgs e)
        {
            show();

        }
        public void show()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.Getalltrain();
        }
        public void show2(string s)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.Getalltrain();
        }

        private void butve_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                string trainid = dataGridView1.SelectedRows[0].Cells["TrainID"].Value.ToString();
               addve f = new addve(trainid);
                f.Show();
                f.d = new addve.Mydel(show2);
                MessageBox.Show("thêm thành công vé tàu mới ");
            }
            else
                MessageBox.Show(" vui lòng chọn một lịch trình!");

        }

        private void butdelte_Click(object sender, EventArgs e)
        { 
            if (dataGridView1.SelectedRows.Count > 0)
        }
    }
}
