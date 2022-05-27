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

namespace pbl.Admin
{
    public partial class addschedule : Form
    {
        
        public addschedule()
        {
            InitializeComponent();
            showsche();
            cbb();


        }
        public void cbb()
        {
            List<string> list = new List<string>();
            list= BLLTRAIN.Instance.Getstation();
            foreach (string s in list)
            {
                cbbDep.Items.Add(s);
            }
            foreach(string s in list)
            {
                cbbDes.Items.Add(s);
            }
        }
        public void showsche()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
        private void bTOK_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(daydep.Value, daydes.Value);
            if (comp >= 0)
            {
                MessageBox.Show("Thời gian đến phải sau thời gian đi!");
                return;
            }
            else
            {
                SCHEDULE s = new SCHEDULE
                {
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                    DepartureTime = daydep.Value,
                    ArrivalTime = daydes.Value,

                };

                BLLTRAIN.Instance.Execute(s);
                showsche();


            }
        }

        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetStation(cbbDep.Text).Distinct())
            {
                cbbDes.Items.Add(s);
            }
        }
        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetStation(cbbDes.Text).Distinct())
            {
                cbbDep.Items.Add(s);
            }
        }
    }
}
