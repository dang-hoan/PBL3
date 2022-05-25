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

namespace pbl.View
{
    public partial class addlichtrinh : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        string scheduleid;
        public addlichtrinh(string s)
        {
            scheduleid = s;
            InitializeComponent();
            GUI();
        }
        public void GUI()
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
                hourdep.Items.Add(i);
               hourdes.Items.Add(i);
            }
            for (int i = 0; i <= 59; i++)
            {
                cbbMinuteDes.Items.Add(i);
                cbbMinuteDep.Items.Add(i);
            }

        }

        private void bTOK_Click(object sender, EventArgs e)
        {
           string DepTime, DesTime;
            DateTime dep, des;
            dep = daydep.Value;
            des = daydes.Value;
            int HourDep = (hourdep.Text == "") ? 0 : Convert.ToInt32(hourdep.Text);
            int Hourdes = (hourdes.Text == "") ? 0 : Convert.ToInt32(hourdes.Text);
            DesTime = daydes.Value.ToString("d/M/yyyy");
            DepTime = daydep.Value.ToString("d/M/yyyy");
            if (cbbDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + hourdep.Text + ":" + cbbMinuteDep.Text;
            }
            if (cbbDes.Text != "" && cbbMinuteDes.Text != "")
            {
                DesTime += " " + hourdes.Text + ":" + cbbMinuteDes.Text;
            }
            int comp = string.Compare(dep.ToString("dd/MM/yyyy"), des.ToString("dd/MM/yyyy"));
            if (comp > 0)
            {
                MessageBox.Show("Ngày đến phải sau ngày đi!");
            }
            else if (comp == 0)
            {
                if (HourDep > Hourdes)
                    MessageBox.Show("Thời gian đến phải sau thời gian đi!");
            }
            else
            if (!BLLTRAIN.Instance.checksch(Convert.ToInt32(schedule.Text)))
            {
                SCHEDULE s = new SCHEDULE
                {

                    ScheduleID    = Convert.ToInt32(schedule.Text),
                    Departure     = cbbDep.Text,
                    Destination   = cbbDes.Text,
                    DepartureTime = dep,
                    ArrivalTime   = des,

                };
                
                BLLTRAIN.Instance.Execute(s);
                MessageBox.Show("OK");
                d();
                this.Close();
            };
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void hourdep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void schedule_TextChanged(object sender, EventArgs e)
        {
            if(BLLTRAIN.Instance.checksch(Convert.ToInt32(schedule.Text)))
            { string s= "*";
                schedule.ForeColor = Color.Red;
                schedule.Text = schedule.Text + "    *";
            } 
             
        }
    }
}
