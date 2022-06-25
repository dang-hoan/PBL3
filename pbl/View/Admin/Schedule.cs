
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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            
            InitializeComponent();
            cbb();
            showsche();
        }
        

        public void showsche()
        {
            dtg.DataSource = BLLTRAIN.Instance.GetSchedule();
        }

        private void baddlt_Click(object sender, EventArgs e)
        {
            
        }
        public void cbb()
        {
            List<CBBSchedule> listDep = new List<CBBSchedule>();
            List<CBBSchedule> listDes = new List<CBBSchedule>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach (CBBSchedule s in listDep) cbbDep.Items.Add(s);
            foreach (CBBSchedule s in listDes) cbbDes.Items.Add(s);
        }
        

        

        private void bdellt_Click(object sender, EventArgs e)
        {

            //if (dtg.SelectedRows.Count > 0)
            //{
            //    foreach (DataGridViewRow row in dtg.SelectedRows)
            //    {
            //        BLLTRAIN.Instance.delschedule(Convert.ToInt32(row.Cells["Malt"].Value));
            //    }
            //}
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }
        //them
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(dateDep.Value, dateDes.Value);
            if (comp >= 0)
            {
                MessageBox.Show("Thời gian đến phải sau thời gian đi!");
                return;
            }
            else
            {
                SCHEDULE s = new SCHEDULE
                {
                    ScheduleID = -1,
                    DepartureID = ((CBBSchedule)cbbDep.SelectedItem).Value,
                    ArrivalID = ((CBBSchedule)cbbDes.SelectedItem).Value,
                    DepartureTime = dateDep.Value,
                    ArrivalTime = dateDes.Value,

                };

                BLLTRAIN.Instance.Execute(s);
                showsche();


            }
        }
        //timkiem
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(dateDep.Value, dateDes.Value);

            if (comp > 0)
            {
                MessageBox.Show("Thời gian đi phải  trước mốc thời gian đến !");
            }


            dtg.DataSource = BLLTRAIN.Instance.GetSchedulead(dateDep.Value.ToString("d/M/yyyy HH:mm"),
                dateDes.Value.ToString("d/M/yyyy HH:mm"), cbbDep.SelectedItem.ToString(), cbbDes.SelectedItem.ToString());
        }

        private void cbbDep_Leave(object sender, EventArgs e)
        {
            if(cbbDep.SelectedItem == cbbDes.SelectedItem)
            {

            }
        }

        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Clear();
            int rep = (cbbDep.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDep.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDestination(rep))
            {
                cbbDes.Items.Add(s);
            }
        }

        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Clear();
            int rep = (cbbDes.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDes.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDeparture(rep))
            {
                cbbDep.Items.Add(s);
            }
        }
    }
}
