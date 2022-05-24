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
    public partial class lichtrinadd : Form
    {
        public lichtrinadd()
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
         public void show()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
        private void butall_Click(object sender, EventArgs e)
        {
            show();
        }

        private void buttrain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string scheduleid = dataGridView1.SelectedRows[0].Cells["ScheduleID"].Value.ToString();
                addtrain f = new addtrain(scheduleid);
                f.Show();
            }
            else
                MessageBox.Show(" vui lòng chọn một lịch trình!");

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

            //   else
            {
                SCHEDULE_View s = new SCHEDULE_View()
                {
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                    // DepartureTime = DepTime,
                };

                dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule2(s);

            }
        }
    }
}
