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
    public partial class lichtrinadd : Form
    {
        public delegate void MyDel(int scheduleid);
        public MyDel d;
        public lichtrinadd()
        {
            InitializeComponent();
            gui();
        }
        public void gui()
        {
            List<CBBSchedule> listDep = new List<CBBSchedule>();
            List<CBBSchedule> listDes = new List<CBBSchedule>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach(CBBSchedule s in listDep) cbbDep.Items.Add(s);
            foreach(CBBSchedule s in listDes) cbbDes.Items.Add(s);
        }
         public void show()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
        private void butall_Click(object sender, EventArgs e)
        {
            show();
        }

        private void buttrain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int scheduleid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ScheduleID"].Value.ToString());
                d(scheduleid);
                this.Close();
            }
            else
                MessageBox.Show(" vui lòng chọn một lịch trình!");

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            SCHEDULE_View s = new SCHEDULE_View()
            {
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                // DepartureTime = DepTime,
            };

            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule2(s);
        }

        private void cbbDep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbDep_Click(object sender, EventArgs e)
        {
            string temp = cbbDep.Text;
            cbbDep.Items.Clear();
            int rep = (cbbDes.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDes.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDeparture(rep))
            {
                cbbDep.Items.Add(s);
            }
            for (int i = 0; i < cbbDep.Items.Count; i++)
            {
                if (cbbDep.Items[i].ToString().Equals(temp))
                {
                    cbbDep.SelectedIndex = i;
                    break;
                }
            }
        }

        private void cbbDes_Click(object sender, EventArgs e)
        {
            string temp = cbbDes.Text;
            cbbDes.Items.Clear();
            int rep = (cbbDep.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDep.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDestination(rep))
            {
                cbbDes.Items.Add(s);
            }
            for (int i = 0; i < cbbDes.Items.Count; i++)
            {
                if (cbbDes.Items[i].ToString().Equals(temp))
                {
                    cbbDes.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
