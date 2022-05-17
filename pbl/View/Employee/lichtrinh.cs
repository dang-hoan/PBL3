using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.DTO;
using pbl.BLL;

namespace pbl.View
{
    public partial class lichtrinh : Form
    {
        public lichtrinh()
        {
            InitializeComponent();
        }
    private void button1_Click(object sender, EventArgs e)
        {
            datve f = new datve();
            f.Show();
        }

        private void butsearch_Click(object sender, EventArgs e)
        {
            string DepTime, DesTime;

            DesTime = dateDes.Value.ToString("d/M/yyyy");
            DepTime = dateDep.Value.ToString("d/M/yyyy");
            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            }
            if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
            }
            SCHEDULE_View s = new SCHEDULE_View()
            {
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                DepartureTime = DepTime,
                ArrivalTime = DesTime,

            };
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s);
        }

        private void bSearch_Click(object sender, EventArgs e)
        {

        }

        private void butall_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }

        private void butdelte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    BLLpeople.instance.delperson(row.Cells["Username"].Value.ToString());
                }
            }

        }
    }
}
