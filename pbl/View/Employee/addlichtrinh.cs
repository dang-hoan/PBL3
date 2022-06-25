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
            foreach (string s in listDep)
            {
                cbbDep.Items.Add(s);
            }
            foreach (string s in listDes)
            {
                cbbDes.Items.Add(s);
            }

        }

        private void bTOK_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(daydep.Value, daydes.Value);
            if (comp > 0)
            {
                MessageBox.Show("Thời gian đến phải sau thời gian đi!");
                return;
            }
            string date1 = daydep.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            if (string.Compare(date1, now) < 0 )
            {
                MessageBox.Show("Lịch trình phải có thời gian bắt đầu từ thời điểm hiện tại!");
                return;
            }
            else
            {
                SCHEDULE s = new SCHEDULE
                {
                    DepartureID = ((CBBSchedule)cbbDep.SelectedItem).Value,
                    ArrivalID = ((CBBSchedule)cbbDes.SelectedItem).Value,
                    DepartureTime = daydep.Value,
                    ArrivalTime = daydes.Value,

                };

                BLLTRAIN.Instance.Execute(s);
                MessageBox.Show("OK");
                d();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void hourdep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
