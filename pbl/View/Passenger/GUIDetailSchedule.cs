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

namespace pbl
{
    public partial class GUIDetailSchedule : Form
    {
        public GUIDetailSchedule()
        {
            InitializeComponent();
            Init();
            dataGridView1.DataSource = new List<SCHEDULE>(BLLTRAIN.Instance.GetSchedule(GUILogin.userName).Distinct());
        }

        private void Init()
        {
            List<string> listDep = new List<string>();
            List<string> listDes = new List<string>();
            BLLTRAIN.Instance.GetStation(GUILogin.userName, ref listDep, ref listDes);
            foreach (string s in listDep.Distinct())
            {
                cbbDep.Items.Add(s);
            }
            foreach (string s in listDes.Distinct())
            {
                cbbDes.Items.Add(s);
            }
            for (int i = 0; i <= 23; i++)
            {
                cbbHourDep.Items.Add(i);
                cbbHourDes.Items.Add(i);
            }
            for(int i = 0; i <= 59; i++)
            {
                cbbMinuteDep.Items.Add(i);
                cbbMinuteDes.Items.Add(i);
            }
        }

        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDestination(GUILogin.userName, cbbDep.Text).Distinct())
            {
                cbbDes.Items.Add(s);
            }
        }

        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDeparture(GUILogin.userName, cbbDes.Text).Distinct())
            {
                cbbDep.Items.Add(s);
            }
        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<SCHEDULE>(BLLTRAIN.Instance.GetSchedule(GUILogin.userName).Distinct());
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string DepTime, DesTime;
            DepTime = dateDep.Value.ToString("d/M/yyyy");
            DesTime = dateDes.Value.ToString("d/M/yyyy");
            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            }
            if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
            }
            SCHEDULE s = new SCHEDULE
            {
                ScheduleID = "",
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                DepartureTime = DepTime,
                ArrivalTime = DesTime
            };
            dataGridView1.DataSource = new List<SCHEDULE>(BLLTRAIN.Instance.GetSchedule(s, GUILogin.userName).Distinct());
        }
        private void cbbHour_Leave(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Text != "")
            {
                int temp;
                bool check = int.TryParse(((ComboBox)sender).Text, out temp);

                if (!check)
                {
                    ((ComboBox)sender).Text = "";
                    MessageBox.Show("Giờ bạn nhập không phải là số!");
                }
                else if (temp < 0 || temp > 23)
                {
                    ((ComboBox)sender).Text = "";
                    MessageBox.Show("Giờ bạn nhập nằm ngoài phạm vi hợp lệ (0 - 23)!");
                }
            }
        }
        private void cbbMinute_Leave(object sender, EventArgs e)
        {
            if (((ComboBox)sender).Text != "")
            {
                int temp;
                bool check = int.TryParse(((ComboBox)sender).Text, out temp);
                if (!check)
                {
                    ((ComboBox)sender).Text = "";
                    MessageBox.Show("Phút bạn nhập không phải là số!");
                }
                else if (temp < 0 || temp > 59)
                {
                    ((ComboBox)sender).Text = "";
                    MessageBox.Show("Phút bạn nhập nằm ngoài phạm vi hợp lệ (0 - 59)!");
                }
            }
        }
        private void cbbStation_Leave(object sender, EventArgs e)
        {
            ComboBox cbb = (ComboBox)sender;
            if(cbb.Text != "")
            {
                foreach(object i in cbb.Items)
                {
                    if (i.ToString().Equals(cbb.Text))
                    {
                        return;
                    }
                }
                ((ComboBox)sender).Text = "";
                MessageBox.Show("Ga bạn nhập không tồn tại hoặc không phù hợp với lịch trình!");
            }
        }
    }
}
