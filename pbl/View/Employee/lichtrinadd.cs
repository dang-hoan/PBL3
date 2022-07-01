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
            show();
            BLLTRAIN.Instance.SetScheduleView(dataGridView1);
        }
        public void gui()
        {
            List<CBBSchedule> listDep = new List<CBBSchedule>();
            List<CBBSchedule> listDes = new List<CBBSchedule>();
            BLLTRAIN.Instance.GetStation2(ref listDep, ref listDes);
            foreach(CBBSchedule s in listDep) cbbDep.Items.Add(s);
            foreach(CBBSchedule s in listDes) cbbDes.Items.Add(s);
            checkBox1.Checked = false;
        }
         public void show()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule3();
        }
        private void butall_Click(object sender, EventArgs e)
        {
            show();
        }

        private void buttrain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if(Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DepartureTime"].Value.ToString()).ToString("yyyy/M/d H:m").CompareTo(DateTime.Now.ToString("yyyy/M/d H:m")) <= 0)
                {
                    MessageBox.Show("Lịch trình bạn chọn đã hết hạn!");
                    return;
                }
                int scheduleid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ScheduleID"].Value.ToString());
                d(scheduleid);
                this.Close();
            }
            else
                MessageBox.Show("Vui lòng chọn một lịch trình!");
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
                if ((comp.CompareTo(now) <= 0) && (comp2.CompareTo(now) < 0))
                {
                    MessageBox.Show("Lịch trình chỉ bắt đầu từ thời điểm hiện tại!");
                }
                else
                {
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
                dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule3(s);
            }
            else
            {
                SCHEDULE_View s = new SCHEDULE_View
                {
                    ScheduleID = -1,
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                };
                dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule3(s);
            }
        }

        private void cbbDep_Click(object sender, EventArgs e)
        {
            string temp = cbbDep.Text;
            cbbDep.Items.Clear();
            int rep = (cbbDes.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDes.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDeparture3(rep))
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
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDestination3(rep))
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
    }
}
