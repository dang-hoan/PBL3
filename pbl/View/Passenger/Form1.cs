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
    public partial class Form1 : Form
    {
        DateTimePicker dateDep = new DateTimePicker();
        DateTimePicker dateDes = new DateTimePicker();
        public delegate void MyDel(SCHEDULE_BLL s);
        public MyDel d { get; set; }
        private void Date(string s, ref string date, ref string hour, ref string minute)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != ' ') date += s[i];
                else
                {
                    for (int j = i + 1; j < s.Length; j++)
                    {
                        if (s[j] != ':') hour += s[j];
                        else
                        {
                            for (int k = j + 1; k < s.Length; k++)
                            {
                                if (s[k] != ':')
                                    minute += s[k];
                                else return;
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }
        public Form1(SCHEDULE_BLL s)
        {
            InitializeComponent();
            cbbDep.Text = s.Departure;
            cbbDes.Text = s.Destination;
            //Init(s.DepartureTime, s.ArrivalTime);
        }
        private void Init(string DepartureTime, string ArrivalTime)
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

            //Khởi tạo thuộc tính DateTimePicker dateDep và dateDes
            //dateDep.Size = new Size(157, 26);
            //dateDep.TabIndex = 25;
            //dateDep.Parent = this;
            //dateDep.Location = new Point(85, label3.Location.Y - 2);
            //dateDep.Format = DateTimePickerFormat.Custom;
            //dateDep.CustomFormat = "dd/MM/yyyy";

            //dateDes.Size = new Size(157, 26);
            //dateDes.TabIndex = 26;
            //dateDes.Parent = this;
            //dateDes.Location = new Point(344, label4.Location.Y - 2);
            //dateDes.Format = DateTimePickerFormat.Custom;
            //dateDes.CustomFormat = "dd/MM/yyyy";
        }
        private void bAccept_Click(object sender, EventArgs e)
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
                    //if (cbbHourDep.Text != "" && cbbHourDes.Text != "" && cbbMinuteDep.Text != "" && cbbMinuteDes.Text != "")
                    //{
                    //    int a = Convert.ToInt32(cbbHourDep.Text);
                    //    int b = Convert.ToInt32(cbbHourDes.Text);
                    //    int c = Convert.ToInt32(cbbMinuteDep.Text);
                    //    int d = Convert.ToInt32(cbbMinuteDes.Text);
                    //    if (a > b)
                    //    {
                    //        MessageBox.Show("Thời gian đến phải lớn hơn thời gian đi!");
                    //        return;
                    //    }
                    //    else if (a == b && c > d)
                    //    {
                    //        MessageBox.Show("Thời gian đến phải lớn hơn thời gian đi!");
                    //        return;
                    //    }
                    //}
                }
            }
            SCHEDULE_BLL s = new SCHEDULE_BLL
            {
                ScheduleID = "",
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                FromDepartureTime = dateFromDep.Value,
                ToDepartureTime = dateToDep.Value,
                FromArrivalTime = dateFromDes.Value,
                ToArrivalTime = dateToDes.Value
            };
            d(s);
            this.Close();
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            //cbbDep.Items.Clear();
            //cbbDep.Items.AddRange(BLLTRAIN.Instance.GetDeparture2(GUILogin.userName, cbbDep.Text).Distinct().ToArray());
            cbbDes.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDestination(GUILogin.userName, cbbDep.Text).Distinct())
            {
                cbbDes.Items.Add(s);
            }
        }

        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            //cbbDes.Items.Clear();
            //cbbDes.Items.AddRange(BLLTRAIN.Instance.GetDestination2(GUILogin.userName, cbbDes.Text).Distinct().ToArray());
            cbbDep.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDeparture(GUILogin.userName, cbbDes.Text).Distinct())
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
    }
}
