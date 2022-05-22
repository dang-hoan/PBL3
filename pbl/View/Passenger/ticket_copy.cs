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
    public partial class ticket_copy : Form
    {
        private bool NoScheduleClick = true;
        private SCHEDULE_BLL schedule = new SCHEDULE_BLL
        {
            ScheduleID = "",
            Departure = "",
            Destination = "",
            FromDepartureTime = DateTime.Now,
            ToDepartureTime = DateTime.Now,
            FromArrivalTime = DateTime.Now,
            ToArrivalTime = DateTime.Now,
        };
        public ticket_copy()
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

        private void Get(SCHEDULE_BLL s)
        {
            schedule.Departure = s.Departure;
            schedule.Destination = s.Destination;
            schedule.FromDepartureTime = s.FromDepartureTime;
            schedule.ToDepartureTime = s.ToDepartureTime;
            schedule.FromArrivalTime = s.FromArrivalTime;
            schedule.ToArrivalTime = s.ToArrivalTime;

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
            if(NoScheduleClick)
                dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(GUILogin.userName, TrainName);
            else
                dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(schedule, GUILogin.userName, TrainName);
        }
        private void Schedule_Click(object sender, EventArgs e)
        {
            Form1 option = new Form1(schedule);
            option.d += new Form1.MyDel(Get);
            option.Show();
            NoScheduleClick = false;
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
