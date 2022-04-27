using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public partial class GUISystemSchedule : Form
    {
        ManageFunction man = new ManageFunction();
        public GUISystemSchedule()
        {
            InitializeComponent();
            Init();
            dataGridView1.DataSource = man.GetSchedule();
        }
        private void Init()
        {
            DataTable dt = man.GetStation();
            foreach (DataRow dr in dt.Rows)
            {
                cbbDep.Items.Add(dr[0]);
                cbbDes.Items.Add(dr[1]);
            }
            for (int i = 0; i <= 23; i++)
            {
                cbbHourDep.Items.Add(i);
                cbbHourDes.Items.Add(i);
            }
            for (int i = 0; i <= 59; i++)
            {
                cbbMinuteDep.Items.Add(i);
                cbbMinuteDes.Items.Add(i);
            }
        }

        private void bBook_Click(object sender, EventArgs e)
        {
            //List<objSCHEDULE> list = new List<objSCHEDULE>();
            //if (dataGridView1.SelectedRows.Count >= 1)
            //{
            //    foreach(DataGridViewRow dr in dataGridView1.SelectedRows)
            //    {
            //        objSCHEDULE obj = new objSCHEDULE()
            //        {
            //            ScheduleID = dr.Cells["ScheduleID"].Value.ToString(),
            //            Departure = dr.Cells["Departure"].Value.ToString(),
            //            Destination = dr.Cells["Destionation"].Value.ToString(),
            //            DepartureTime = Convert.ToDateTime(dr.Cells["DepartureTime"].Value.ToString()),
            //            ArrivalTime = Convert.ToDateTime(dr.Cells["ArrivalTime"].Value.ToString())
            //        };
            //        list.Add(obj);
            //    }
            //    GUIBook book = new GUIBook();
            //    book.Show();
            //}
            if(dataGridView1.SelectedRows.Count == 1)
            {
                DataGridViewRow dr = dataGridView1.SelectedRows[0];
                GUIBook book = new GUIBook(dr.Cells["Departure"].Value.ToString(), dr.Cells["Destination"].Value.ToString(), ((DateTime)dr.Cells["DepartureTime"].Value).ToString("yyyy/MM/dd HH:mm:ss"), ((DateTime)dr.Cells["ArrivalTime"].Value).ToString("yyyy/MM/dd HH:mm:ss"));
                book.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn tối thiểu một lịch trình để đặt vé!");
            }

        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = man.GetSchedule();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            bool hasInputDep = false;
            bool hasInputDes = false;
            string DepTime, DesTime;
            DepTime = dateDep.Value.ToString("yyyy/MM/dd");
            DesTime = dateDes.Value.ToString("yyyy/MM/dd");
            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
                hasInputDep = true;
            }
            else if (cbbHourDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + "0";
                hasInputDep = true;
            }
            if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
                hasInputDes = true;
            }
            else if (cbbHourDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + "0";
                hasInputDes = true;
            }
            dataGridView1.DataSource = man.GetSchedule(cbbDep.Text, cbbDes.Text, rbOne.Checked || !rbRound.Checked, DepTime, DesTime, hasInputDep, hasInputDes);
        }
        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = man.GetStation();
            cbbDes.Items.Clear();
            if (cbbDep.Text != "")
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbbDes.Items.Add(dr[1]);
                }
                cbbDes.Items.Remove(cbbDep.SelectedItem);
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbbDes.Items.Add(dr[1]);
                }
            }
        }

        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = man.GetStation();
            cbbDep.Items.Clear();
            if (cbbDes.Text != "")
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbbDep.Items.Add(dr[0]);
                }
                cbbDep.Items.Remove(cbbDes.SelectedItem);
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    cbbDep.Items.Add(dr[0]);
                }
            }
        }
    }
}
