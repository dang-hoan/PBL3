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
    public partial class GUIOption : Form
    {
        ManageFunction man = new ManageFunction();
        DateTimePicker dateDep = new DateTimePicker(); 
        DateTimePicker dateDes = new DateTimePicker();
        public delegate void MyDel(string Departure, string Destination, bool Type, string DepartureTime, string DestinationTime, bool hasInputDep, bool hasInputDes);
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
        public GUIOption(string Departure, string Destination, bool Type, string DepartureTime, string ArrivalTime)
        {
            InitializeComponent();
            cbbDep.Text = Departure;
            cbbDes.Text = Destination;
            if (Type) rbOne.Checked = true;
            else rbRound.Checked = true;
            Init(DepartureTime, ArrivalTime);           
        }
        private void Init(string DepartureTime, string ArrivalTime)
        {
            DataTable dt = man.GetStation(GUI.userName);
            foreach(DataRow dr in dt.Rows)
            {
                cbbDep.Items.Add(dr[0]);
                cbbDes.Items.Add(dr[1]);
            }
            for(int i = 0; i < 24; i++)
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
            if (des != "") dateDes.Value = Convert.ToDateTime(des); cbbHourDes.Text = hourDes; cbbMinuteDes.Text = minuteDes;
        }
        private void bAccept_Click(object sender, EventArgs e)
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
            d(cbbDep.Text, cbbDes.Text, rbOne.Checked || !rbRound.Checked, DepTime, DesTime, hasInputDep, hasInputDes);
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = man.GetStation(GUI.userName);
        }

        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = man.GetStation(GUI.userName);
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
            DataTable dt = man.GetStation(GUI.userName);
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
