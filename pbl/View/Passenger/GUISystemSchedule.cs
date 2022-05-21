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
    public partial class GUISystemSchedule : Form
    {
        public GUISystemSchedule()
        {
            InitializeComponent();
            Init();
            dateDep.MinDate = DateTime.Now.AddDays(-1); ;
            dateDep.MaxDate = DateTime.Now.AddYears(100);
            dateDes.MinDate = DateTime.Now.AddDays(-1); ;
            dateDes.MaxDate = DateTime.Now.AddYears(100);
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
        private void Init()
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
            List<string> list = new List<string>();
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    list.Add(dr.Cells["ScheduleID"].Value.ToString());
                }
                GUIBook book = new GUIBook(list);
                book.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn tối thiểu một lịch trình để đặt vé!");
            }
        }
        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            int comp = string.Compare(dateDep.Value.ToString("yyyy/MM/dd"), dateDes.Value.ToString("yyyy/MM/dd"));
            if (comp > 0)
            {
                MessageBox.Show("Ngày đến phải lớn hơn ngày đi!");
                return;
            }
            else
            {
                if (comp == 0)
                {
                    if (cbbHourDep.Text != "" && cbbHourDes.Text != "" && cbbMinuteDep.Text != "" && cbbMinuteDes.Text != "")
                    {
                        int a = Convert.ToInt32(cbbHourDep.Text);
                        int b = Convert.ToInt32(cbbHourDes.Text);
                        int c = Convert.ToInt32(cbbMinuteDep.Text);
                        int d = Convert.ToInt32(cbbMinuteDes.Text);
                        if (a > b)
                        {
                            MessageBox.Show("Thời gian đến phải lớn hơn thời gian đi!");
                            return;
                        }
                        else if(a == b && c > d)
                        {
                            MessageBox.Show("Thời gian đến phải lớn hơn thời gian đi!");
                            return;
                        }
                    }
                }
            }
            string DepTime, DesTime;
            DepTime = dateDep.Value.ToString("dd/MM/yyyy");
            DesTime = dateDes.Value.ToString("dd/MM/yyyy");
            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            }
            if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
            }
            SCHEDULE_View s = new SCHEDULE_View
            {
                ScheduleID = "",
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                DepartureTime = DepTime,
                ArrivalTime = DesTime
            };
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s);
            
        }
        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDestination(cbbDep.Text).Distinct())
            {
                cbbDes.Items.Add(s);
            }
        }
        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDeparture(cbbDes.Text).Distinct())
            {
                cbbDep.Items.Add(s);
            }
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
            if (cbb.Text != "")
            {
                foreach (object i in cbb.Items)
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
        public int[] numberChar = new int[5] { 14, 25, 25, 30, 30 };
        private void pSave_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.Print(dataGridView1, numberChar);
        }
        private void Date_Leave(object sender, EventArgs e)
        {
            string Time;
            Time = ((DateTimePicker)sender).Value.ToString("yyyy/MM/dd");
            if (string.Compare(Time, DateTime.Now.ToString("yyyy/MM/dd")) < 0)
            {
                MessageBox.Show("Lịch trình phải có ngày bắt đầu từ ngày hiện tại!");
                ((DateTimePicker)sender).Value = DateTime.Now;
                return;
            }
        }
    }
}
