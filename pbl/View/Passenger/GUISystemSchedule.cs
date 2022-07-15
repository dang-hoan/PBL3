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

namespace pbl.View
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
            sortA.BackColor = Color.White;
            sortZ.BackColor = Color.White;
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
            cbbSort.Items.AddRange(new string[]
            {
                "Mã lịch trình", "Ga đi", "Ga đến", "Thời gian đi", "Thời gian đến"
            });
        }
        private void bBook_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                //foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                //{
                //    list.Add(Convert.ToInt32(dr.Cells["ScheduleID"].Value.ToString()));
                //}
                //GUIBook2 book = new GUIBook2(list);
                //book.Show();
                if((Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells["DepartureTime"].Value.ToString())).CompareTo(DateTime.Now) <= 0)
                {
                    MessageBox.Show("Lịch trình có mã " + (dataGridView1.SelectedRows[0].Cells["ScheduleID"].Value.ToString()) + " đã hết hạn!");
                    return;
                }
                GUIBook book = new GUIBook(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ScheduleID"].Value.ToString()));
                book.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn một lịch trình để đặt vé!");
            }
        }
        private void bShowAll_Click(object sender, EventArgs e)
        {
            sortA.BackColor = Color.White;
            sortZ.BackColor = Color.White;
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
            sortA.BackColor = Color.White;
            sortZ.BackColor = Color.White;
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s);
            
        }
        public int[] numberChar = new int[5] { 17, 25, 25, 30, 30 };
        private void pSave_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.Print(dataGridView1, numberChar,"Lịch trình hệ thống", false);
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

        private void sortA_Click(object sender, EventArgs e)
        {
            if (cbbSort.Text != "")
            {
                sortA.BackColor = Color.Green;
                sortZ.BackColor = Color.White;
                List<SCHEDULE_View> list = dataGridView1.DataSource as List<SCHEDULE_View>;
                dataGridView1.DataSource = BLLTRAIN.Instance.SortDetail(list, cbbSort.SelectedIndex, true);
            }
            else
            {
                MessageBox.Show("Chưa chọn thuộc tính sắp xếp!");
                return;
            }
        }

        private void sortZ_Click(object sender, EventArgs e)
        {
            if (cbbSort.Text != "")
            {
                sortZ.BackColor = Color.Green;
                sortA.BackColor = Color.White;
                List<SCHEDULE_View> list = dataGridView1.DataSource as List<SCHEDULE_View>;
                dataGridView1.DataSource = BLLTRAIN.Instance.SortDetail(list, cbbSort.SelectedIndex, false);
            }
            else
            {
                MessageBox.Show("Chưa chọn thuộc tính sắp xếp!");
                return;
            }
        }
    }
}
