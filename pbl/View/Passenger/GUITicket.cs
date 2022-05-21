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
    public partial class GUITicket : Form
    {
        private SCHEDULE_View schedule = new SCHEDULE_View
        {
            ScheduleID = "",
            Departure = "",
            Destination = "",
            DepartureTime = DateTime.Now.ToString("dd/MM/yyyy H:m:s"),
            ArrivalTime = DateTime.Now.ToString("dd/MM/yyyy H:m:s")
        };
        private string devDay, devHour, devMinute;
        public GUITicket()
        {
            InitializeComponent();
            Init();
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(GUILogin.userName);
        }
        private void Init()
        {
            cbbTrain.Items.Add("Tất cả");
            cbbTrain.Items.AddRange(BLLTRAIN.Instance.GetTrain(GUILogin.userName).Distinct().ToArray());
        }

        private void Get(SCHEDULE_View s)
        {
            schedule.Departure = s.Departure;
            schedule.Destination = s.Destination;
            schedule.DepartureTime = s.DepartureTime;
            schedule.ArrivalTime = s.ArrivalTime;

            cbbTrain.Items.Clear();
            cbbTrain.Items.Add("Tất cả");
            cbbTrain.Items.AddRange(BLLTRAIN.Instance.GetTrain(schedule, GUILogin.userName).Distinct().ToArray());
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn huỷ những vé đã chọn không?", "Thông báo", MessageBoxButtons.OKCancel);
                if (res == DialogResult.OK)
                {
                    foreach (DataGridViewRow i in dataGridView1.SelectedRows)
                    {
                        BLLTRAIN.Instance.SetTicket(i.Cells["TicketID"].Value.ToString(), GUILogin.userName, false);
                    }
                    MessageBox.Show("Đã huỷ những vé bạn chọn!");
                    cbbTrain.Items.Clear();
                    Init();
                    dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(GUILogin.userName);
                }
            }
        }
        private void Reload()
        {
            string TrainName = "";
            if(cbbTrain.Text != "Tìm theo tàu" && cbbTrain.Text != "Tất cả") TrainName = cbbTrain.Text;
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(schedule, GUILogin.userName, TrainName, devDay, devHour, devMinute);
        }
        private void Schedule_Click(object sender, EventArgs e)
        {
            GUIOption option = new GUIOption(schedule, "", "", "");
            option.d += new GUIOption.MyDel(Get);
            option.Show();
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(GUILogin.userName);
        }
        public int[] numberChar = new int[10] { 14, 10, 25, 8, 14, 25, 25, 25, 30, 30 };
        private void pSave_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.Print(dataGridView1, numberChar);
        }
    }
}
