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
        public delegate void Mydel(string scheduleid);
        public Mydel d;
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
            DateTime dep, des;

            des = daydes.Value;
            dep = daydep.Value;
            if (BLLTRAIN.Instance.checksch(schedule.Text))
            {
                SCHEDULE s = new SCHEDULE
                {

                    ScheduleID    =   schedule.Text,
                    Departure     =   cbbDep.Text,
                    Destination   =   cbbDes.Text,
                    DepartureTime = dep,
                    ArrivalTime   = des,

                };

                BLLTRAIN.Instance.Execute(s);
            };
            d("");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
