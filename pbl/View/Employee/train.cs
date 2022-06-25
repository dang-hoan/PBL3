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

        private void butstate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells["State"].Value.ToString() != "Hoạt động")
                {
                   // string scheduleid = dataGridView1.SelectedRows[0].Cells["ScheduleID"].Value.ToString();
                   // trainve f = new trainve(Convert.ToInt32(scheduleid));
                   // f.Show();
                   //f.d= new trainve.mydel(show);
                }
                
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

        private void butall_Click_1(object sender, EventArgs e)
        {
            show();
        }
    }
}
