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
            gui();
        }
        public void gui()
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
            dateFromDep.Enabled = false;
            dateFromDes.Enabled = false;
            dateToDep.Enabled = false;
            dateToDes.Enabled = false;
        }
       public void show ()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule2();
        }
        private void butall_Click(object sender, EventArgs e)
        {
            show();
        }

        private void butdelte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    //BLLTRAIN.Instance.delschedule(Convert.ToInt32(row.Cells["ScheduleID"].Value.ToString()));
                }
            }
            show();
        }

        private void themlt_Click(object sender, EventArgs e)
        {
            addlichtrinh f = new addlichtrinh("");
           
            f.d = new addlichtrinh.Mydel(show);
            f.Show();
        }

    
        private void bSearch_Click(object sender, EventArgs e)
        {
            string date1 = dateFromDep.Value.ToString("yyyy/MM/dd HH:mm");
            string date2 = dateToDep.Value.ToString("yyyy/MM/dd HH:mm");
            string date3 = dateFromDes.Value.ToString("yyyy/MM/dd HH:mm");
            string date4 = dateToDes.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
          
           
            
                if (checkBox1.Checked)
                {
                    int comp = DateTime.Compare(dateFromDep.Value, dateToDep.Value);
                    int comp2 = DateTime.Compare(dateFromDes.Value, dateToDes.Value);
                    int comp3 = DateTime.Compare(dateFromDep.Value, dateToDes.Value);
                    if (comp > 0 || comp2 > 0)
                    {
                        if (comp > 0 && comp2 > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong cả ngày đi và ngày đến)!");
                        else if (comp > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đi)!");
                        else MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đến)!");
                        return;
                    }
                    if (comp3 >= 0)
                    {
                        MessageBox.Show("Mốc thời gian đến trong ngày đến tối thiểu phải sau mốc thời gian từ trong ngày đi!");
                    }
                }

            if (checkBox1.Checked)
            {
                SCHEDULE_BLL s = new SCHEDULE_BLL
                {
                    ScheduleID = -1,
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                    FromDepartureTime = dateFromDep.Value,
                    ToDepartureTime = dateToDep.Value,
                    FromArrivalTime = dateFromDes.Value,
                    ToArrivalTime = dateToDes.Value
                };
                dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s);
            }
            else
            {
                SCHEDULE_View s = new SCHEDULE_View
                {
                    ScheduleID = -1,
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                };
                dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule2(s);
            }
            
        }

        private void buttrain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                string state = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DepartureTime"].Value).ToString("yyyy/MM/dd HH:mm");
                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
                if (string.Compare(state, now) > 0)
                {
                    int scheduleid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ScheduleID"].Value.ToString());
                    addtrain f = new addtrain(scheduleid);
                    f.d = new addtrain.Mydel(show);
                    f.Show();
                }
                else
                { MessageBox.Show(" Chuyến tàu đã xuất phát "); }
            }
            else
            MessageBox.Show(" vui lòng chọn một lịch trình!");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
                if (!checkBox1.Checked)
                {
                    dateFromDep.Enabled = false;
                    dateFromDes.Enabled = false;
                    dateToDep.Enabled = false;
                    dateToDes.Enabled = false;

                }
                else
                {
                    dateFromDep.Enabled = true;
                    dateFromDes.Enabled = true;
                    dateToDep.Enabled = true;
                    dateToDes.Enabled = true;

                }

            
        }

        private void lichtrinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDestination(cbbDep.Text).Distinct())
            {
                cbbDes.Items.Add(s);
            }
        }

        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDeparture(cbbDes.Text).Distinct())
            {
                cbbDep.Items.Add(s);
            }
        }
    }
}
