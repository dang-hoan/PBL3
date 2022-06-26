
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
            dtg.DataSource = BLLTRAIN.Instance.GetSchedule2();
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
            if (dtg.SelectedRows.Count > 0)
            {
                for(int i = 0; i < dtg.SelectedRows.Count; i++)
                    BLLTRAIN.Instance.DeleteSchedule(Convert.ToInt32(dtg.SelectedRows[i].Cells["Mã lịch trình"].Value.ToString()));

            }
            else MessageBox.Show("Hãy chọn ít nhất 1 lịch trình để xoá!");
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
                if (cbbDep.SelectedItem == null) MessageBox.Show("Yes");
                MessageBox.Show(cbbDep.Text);
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
                return;
            }


            dtg.DataSource = BLLTRAIN.Instance.GetSchedulead(dateDep.Value.ToString("d/M/yyyy HH:mm"),
                dateDes.Value.ToString("d/M/yyyy HH:mm"), cbbDep.Text, cbbDes.Text);
        }


        private void cbbDep_Leave(object sender, EventArgs e)
        {
            if(cbbDep.SelectedItem == cbbDes.SelectedItem)
            {

            }
        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            showsche();
        }

        private void cbbDep_Click(object sender, EventArgs e)
        {
            string temp = cbbDep.Text;
            cbbDep.Items.Clear();
            int rep = (cbbDes.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDes.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDeparture2(rep))
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
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDestination2(rep))
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
