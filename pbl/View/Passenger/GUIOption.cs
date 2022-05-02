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
    public partial class GUIOption : Form
    {
        ManageFunction man = new ManageFunction();
        DateTimePicker dateDep = new DateTimePicker(); 
        DateTimePicker dateDes = new DateTimePicker();
        public delegate void MyDel(SCHEDULE s);
        public MyDel d { get; set; }
        private void Date(string s, ref string date, ref string hour, ref string minute)
        {
            for(int i=0; i<s.Length; i++)
            {
                if (s[i] != ' ') date += s[i];
                else
                {
                    for(int j = i + 1; j < s.Length; j++)
                    {
                        if(s[j] != ':') hour += s[j];
                        else
                        {
                            for(int k = j + 1; k < s.Length; k++) minute += s[k];
                            break;
                        }
                    }
                    break;
                }
            }
        }
        public GUIOption(SCHEDULE s)
        {
            InitializeComponent();
            cbbDep.Text = s.Departure;
            cbbDes.Text = s.Destination;
            Init(s.DepartureTime.ToString(), s.ArrivalTime.ToString());
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
            for (int i = 0; i < 24; i++)
            {
                cbbHourDep.Items.Add(i);
                cbbHourDes.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                cbbMinuteDep.Items.Add(i);
                cbbMinuteDes.Items.Add(i);
            }

            //Khởi tạo thuộc tính DateTimePicker dateDep và dateDes
            dateDep.Size = new Size(157, 26);
            dateDep.TabIndex = 25;
            dateDep.Parent = this;
            dateDep.Location = new Point(85, 82);
            dateDep.Format = DateTimePickerFormat.Custom;
            dateDep.CustomFormat = "dd/MM/yyyy";

            dateDes.Size = new Size(157, 26);
            dateDes.TabIndex = 26;
            dateDes.Parent = this;
            dateDes.Location = new Point(344, 80);
            dateDes.Format = DateTimePickerFormat.Custom;
            dateDes.CustomFormat = "dd/MM/yyyy";

            string dep = "", hourDep = "", minuteDep = "";
            Date(DepartureTime, ref dep, ref hourDep, ref minuteDep);
            if (dep != "") dateDep.Value = Convert.ToDateTime(dep);
            cbbHourDep.Text = hourDep; cbbMinuteDep.Text = minuteDep;
            string des = "", hourDes = "", minuteDes = "";
            Date(ArrivalTime, ref des, ref hourDes, ref minuteDes);
            if (des != "") dateDes.Value = Convert.ToDateTime(des);
            cbbHourDes.Text = hourDes; cbbMinuteDes.Text = minuteDes;
        }
        private void bAccept_Click(object sender, EventArgs e)
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
            d(s);
            this.Close();
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Clear();
            if (cbbDep.Text != "")
            {
                foreach (string s in BLLTRAIN.Instance.GetDestination(GUILogin.userName).Distinct())
                {
                    cbbDes.Items.Add(s);
                }
                cbbDes.Items.Remove(cbbDep.Text);
            }
            else
            {
                foreach (string s in BLLTRAIN.Instance.GetDestination(GUILogin.userName).Distinct())
                {
                    cbbDes.Items.Add(s);
                }
            }
        }

        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Clear();
            if (cbbDes.Text != "")
            {
                foreach (string s in BLLTRAIN.Instance.GetDeparture(GUILogin.userName).Distinct())
                {
                    cbbDep.Items.Add(s);
                }
                cbbDep.Items.Remove(cbbDes.SelectedItem);
            }
            else
            {
                foreach (string s in BLLTRAIN.Instance.GetDeparture(GUILogin.userName).Distinct())
                {
                    cbbDep.Items.Add(s);
                }
            }
        }
    }
}
