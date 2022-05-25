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
    public partial class trainve : Form
    {
        public  delegate void mydel(string trainid );
        public mydel d;
        public trainve()
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
            string DepTime;

            DepTime = dateDep.Value.ToString("d/M/yyyy");
            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            }

            else
            {
                SCHEDULE_View s = new SCHEDULE_View()
                {
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                    DepartureTime = DepTime,
                };
                int scheduleid = -1;
                foreach (SCHEDULE_View i in BLLTRAIN.Instance.GetSchedule2(s))
                {
                    scheduleid = i.ScheduleID;
                    MessageBox.Show(scheduleid.ToString());
                }
                dataGridView1.DataSource = BLLTRAIN.Instance.GetTrain2(scheduleid);


            }
        }

        private void buttrain_Click(object sender, EventArgs e)
        {
            addtrain f = new addtrain(-1);
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

        private void butve_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string scheduleid = dataGridView1.SelectedRows[0].Cells["TrainID"].Value.ToString();
                d(scheduleid);
                this.Close();
            }
            else
                MessageBox.Show(" vui lòng chọn một lịch trình!");

        }
    }
    }

