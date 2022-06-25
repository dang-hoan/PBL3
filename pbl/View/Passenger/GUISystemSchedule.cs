using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;
using pbl.DTO;

namespace pbl
{
    public partial class GUISystemSchedule : Form
    {
        public GUISystemSchedule()
        {
            InitializeComponent();
            Init();
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nl");
            dateFromDep.MinDate = DateTime.Now;
            dateFromDep.MaxDate = DateTime.Now.AddYears(100);
            dateToDep.MinDate = DateTime.Now;
            dateToDep.MaxDate = DateTime.Now.AddYears(100);
            dateFromDes.MinDate = DateTime.Now;
            dateFromDes.MaxDate = DateTime.Now.AddYears(100);
            dateToDes.MinDate = DateTime.Now;
            dateToDes.MaxDate = DateTime.Now.AddYears(100);
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
            BLLTRAIN.Instance.SetScheduleView(dataGridView1);
        }
        private void Init()
        {
            List<CBBSchedule> listDep = new List<CBBSchedule>();
            List<CBBSchedule> listDes = new List<CBBSchedule>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach (CBBSchedule s in listDep) cbbDep.Items.Add(s);
            foreach (CBBSchedule s in listDes) cbbDes.Items.Add(s);
        }
        private void bBook_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    list.Add(Convert.ToInt32(dr.Cells["ScheduleID"].Value.ToString()));
                }
                GUIBook book = new GUIBook(list);
                book.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn tối thiểu một lịch trình để đặt vé!");
            }
        }
        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(dateFromDep.Value, dateToDep.Value);
            int comp2 = DateTime.Compare(dateFromDes.Value, dateToDes.Value);
            int comp3 = DateTime.Compare(dateFromDep.Value, dateFromDes.Value);
            if (comp > 0 || comp2 > 0)
            {
                if (comp > 0 && comp2 > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong cả ngày đi và ngày đến)!");
                else if (comp > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đi)!");
                else MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đến)!");
                return;
            }
            if(comp3 >= 0)
            {
                MessageBox.Show("Mốc thời gian từ trong ngày đến tối thiểu phải sau mốc thời gian từ trong ngày đi!");
                return;
            }
            string date1 = dateFromDep.Value.ToString("yyyy/MM/dd HH:mm");
            string date2 = dateToDep.Value.ToString("yyyy/MM/dd HH:mm");
            string date3 = dateFromDes.Value.ToString("yyyy/MM/dd HH:mm");
            string date4 = dateToDes.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            if (string.Compare(date1, now) < 0 || string.Compare(date2, now) < 0 || string.Compare(date3, now) < 0 || string.Compare(date4, now) < 0)
            {
                MessageBox.Show("Lịch trình phải có thời gian bắt đầu từ thời điểm hiện tại!");
                return;
            }
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
        private void cbbStation_Leave(object sender, EventArgs e)
        {
            ComboBox cbb = (ComboBox)sender;
            if (cbb.Text != "")
            {
                foreach (object i in cbb.Items)
                {
                    if (i.ToString().Equals(cbb.Text))
                    {
                        return;
                    }
                }
                ((ComboBox)sender).Text = "";
                MessageBox.Show("Ga bạn nhập không tồn tại hoặc không phù hợp với lịch trình!");
            }
        }
        public int[] numberChar = new int[5] { 17, 25, 25, 30, 30 };
        private void pSave_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.Print(dataGridView1, numberChar,"Lịch trình hệ thống");
        }
    }
}
