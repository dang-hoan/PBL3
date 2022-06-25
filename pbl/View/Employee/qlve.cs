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
    public partial class qlve : Form
    {
        public qlve()
        {
            InitializeComponent();
            gui();

        }
        PBL3 db = new PBL3();

        public void gui()
        {
            List<CBBSchedule> listDep = new List<CBBSchedule>();
            List<CBBSchedule> listDes = new List<CBBSchedule>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach (CBBSchedule s in listDep) cbbDep.Items.Add(s);
            foreach (CBBSchedule s in listDes) cbbDes.Items.Add(s);
            dateFromDep.Enabled = false;
            dateFromDes.Enabled = false;
            dateToDep.Enabled = false;
            dateToDes.Enabled = false;
            show();
        }
        public void show()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.Getallve();
        }
        public void show2(string s)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.Getallve();
        }
        private void butsearch_Click(object sender, EventArgs e)
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
                dataGridView1.DataSource = BLLTRAIN.Instance.Getallve2(s);
            }
            else
            {
                SCHEDULE_BLL s = new SCHEDULE_BLL
                {
                    ScheduleID = -1,
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                };
                dataGridView1.DataSource = BLLTRAIN.Instance.Getallve(s);
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int scheduleid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Malichtrinh"].Value.ToString());
                int trainid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Matau"].Value.ToString());
                bookve f = new bookve(scheduleid, trainid,"xem");
                f.Show();
                f.d = new bookve.Mydel(show2);
            }   
               
        }

        private void butmua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells["Trangthai"].Value.ToString() == "Hoạt động")
                {
                    int scheduleid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Malichtrinh"].Value.ToString());
                    int trainid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Matau"].Value.ToString());
                    bookve f = new bookve(scheduleid,trainid,"mua");
                    f.Show();
                    f.d = new bookve.Mydel(show2);
                }
                else
                {
                    MessageBox.Show(" Tàu đã ngừng hoạt động!");
                }
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
