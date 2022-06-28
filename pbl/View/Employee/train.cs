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
    public partial class train : Form
    {
     
        public train()
        {
            InitializeComponent();
            gui();
            show();
        }
        public void gui()
        {
            dateFromDep.Value = DateTime.Now;
            dateToDep.Value = DateTime.Now;
            dateFromDes.Value = DateTime.Now;
            dateToDes.Value = DateTime.Now;
            List<CBBSchedule> listDep = new List<CBBSchedule>();
            List<CBBSchedule> listDes = new List<CBBSchedule>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach (CBBSchedule s in listDep) cbbDep.Items.Add(s);
            foreach (CBBSchedule s in listDes) cbbDes.Items.Add(s);
            dateFromDep.Enabled = false;
            dateFromDes.Enabled = false;
            dateToDep.Enabled = false;
            dateToDes.Enabled = false;
            reset();
        }

      
        private void butall_Click(object sender, EventArgs e)
        {
            reset();

        }
        public void show()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.Getalltrain();
        }
        public void show2(string s)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.Getalltrain();
        }

        private void butve_Click(object sender, EventArgs e)
        {
            //butdelte_Click(sender, e);
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells["State"].Value.ToString() == "Hoạt động")
                {
                    int trainid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TrainID"].Value.ToString());
                    addve f = new addve(trainid);
                    f.Show();
                    f.d = new addve.Mydel(show2);
                }
                else
                {
                    MessageBox.Show(" Tàu đã ngừng hoạt động!");
                }    
            }
            else
                MessageBox.Show(" vui lòng chọn một lịch trình!");

        }
        public void reset ()     
        {
            show();
                foreach (DataGridViewRow i in dataGridView1.Rows)
                {
                    int scheduleid = Convert.ToInt32(i.Cells["ScheduleID"].Value.ToString());
                    BLLTRAIN.Instance.trainstate(scheduleid);
                    show();
                }
  
        }

        private void buttrain_Click_1(object sender, EventArgs e)
        {

            addtrain f = new addtrain(-1);
            f.Show();
            f.d = new addtrain.Mydel(show);

        }

        private void bSearch_Click_1(object sender, EventArgs e)
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
                dataGridView1.DataSource = BLLTRAIN.Instance.GetTrain2(s);
            }
            else
            {
                SCHEDULE_BLL s = new SCHEDULE_BLL
                {
                    ScheduleID = -1,
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                };
                dataGridView1.DataSource = BLLTRAIN.Instance.GetTrain3(s);
            }  
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
        private void butall_Click_1(object sender, EventArgs e)
        {
            show();
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

        private void bDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow r in dataGridView1.SelectedRows)
                {
                    BLLTRAIN.Instance.DeleteTrip(Convert.ToInt32(r.Cells[0].Value.ToString()), Convert.ToInt32(r.Cells[1].Value.ToString()));
                }
                MessageBox.Show("Đã xoá thành công các chuyến tàu bạn chọn!");
                show();
            }
            else
            {
                MessageBox.Show("Hãy chọn ít nhất 1 chuyến tàu để xoá!");
            }
        }
    }
}
