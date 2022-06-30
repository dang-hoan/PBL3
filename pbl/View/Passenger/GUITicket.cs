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
    public partial class GUITicket : Form
    {
        private bool NoScheduleClick = true;
        private SCHEDULE_User_BLL schedule = new SCHEDULE_User_BLL
        {
            ScheduleID = -1,
            DepartureID = -1,
            ArrivalID = -1,
            FromDepartureTime = DateTime.Now,
            ToDepartureTime = DateTime.Now,
            FromArrivalTime = DateTime.Now,
            ToArrivalTime = DateTime.Now,
        };
        public GUITicket()
        {
            InitializeComponent();
            Init();
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nl");
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(GUILogin.userName);
            BLLTRAIN.Instance.SetTicketUserView(dataGridView1);
        }
        private void Init()
        {
            cbbTrain.Items.Add("Tất cả");
            cbbTrain.Items.AddRange(BLLTRAIN.Instance.GetTrain(GUILogin.userName).ToArray());
            cbbSort.Items.AddRange(new string[]
            {
                "Mã lịch trình", "Mã tàu", "Tên tàu", "Mã vé", "Số ghế", "Giá vé"
                , "Ga đi", "Ga đến", "Thời gian đi", "Thời gian đến"
            });
        }

        private void Get(SCHEDULE_User_BLL s)
        {
            schedule.DepartureID = s.DepartureID;
            schedule.ArrivalID = s.ArrivalID;
            schedule.FromDepartureTime = s.FromDepartureTime;
            schedule.ToDepartureTime = s.ToDepartureTime;
            schedule.FromArrivalTime = s.FromArrivalTime;
            schedule.ToArrivalTime = s.ToArrivalTime;
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
                        BLLTRAIN.Instance.SetTicket(Convert.ToInt32(i.Cells["TicketID"].Value.ToString()), GUILogin.userName, false);
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
            if (cbbTrain.Text != "Tìm theo tàu" && cbbTrain.Text != "Tất cả") TrainName = cbbTrain.Text;
            if (NoScheduleClick)
                dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(GUILogin.userName, TrainName);
            else
            {
                cbbTrain.Items.Clear();
                cbbTrain.Items.Add("Tất cả");
                cbbTrain.Items.AddRange(BLLTRAIN.Instance.GetTrain(schedule, GUILogin.userName).ToArray());
                dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(schedule, GUILogin.userName, TrainName);
            }
        }
        private void Schedule_Click(object sender, EventArgs e)
        {
            GUIOption option = new GUIOption(schedule);
            option.d += new GUIOption.MyDel(Get);
            option.Show();
            NoScheduleClick = false;
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void bShowAll_Click(object sender, EventArgs e)
        {
            cbbTrain.Items.Clear();
            cbbTrain.Items.Add("Tất cả");
            cbbTrain.Items.AddRange(BLLTRAIN.Instance.GetTrain(GUILogin.userName).ToArray());
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(GUILogin.userName);
        }
        public int[] numberChar = new int[10] { 17, 10, 25, 13, 14, 25, 25, 25, 30, 30 };
        private void pSave_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.Print(dataGridView1, numberChar,"Vé cá nhân");
        }

        private void sortA_Click(object sender, EventArgs e)
        {
            if (cbbSort.Text != "")
            {
                sortA.BackColor = Color.Green;
                sortZ.BackColor = Color.White;
                List<TICKET_User_View> list = new List<TICKET_User_View>();
                foreach (DataGridViewRow i in dataGridView1.Rows)
                {
                    TICKET_User_View s = new TICKET_User_View
                    {
                        ScheduleID = Convert.ToInt32(i.Cells[0].Value.ToString()),
                        TrainID = Convert.ToInt32(i.Cells[1].Value.ToString()),
                        TrainName = i.Cells[2].Value.ToString(),
                        TicketID = Convert.ToInt32(i.Cells[3].Value.ToString()),
                        SeatNo = i.Cells[4].Value.ToString(),
                        TicketPrice = Convert.ToDouble(i.Cells[5].Value.ToString()),
                        Departure = i.Cells[6].Value.ToString(),
                        Destination = i.Cells[7].Value.ToString(),
                        DepartureTime = Convert.ToDateTime(i.Cells[8].Value.ToString()),
                        ArrivalTime = Convert.ToDateTime(i.Cells[9].Value.ToString())
                    };
                    list.Add(s);
                }
                dataGridView1.DataSource = BLLTRAIN.Instance.Sort(list, cbbSort.SelectedIndex, true);
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
                List<TICKET_User_View> list = new List<TICKET_User_View>();
                foreach (DataGridViewRow i in dataGridView1.Rows)
                {
                    TICKET_User_View s = new TICKET_User_View
                    {
                        ScheduleID = Convert.ToInt32(i.Cells[0].Value.ToString()),
                        TrainID = Convert.ToInt32(i.Cells[1].Value.ToString()),
                        TrainName = i.Cells[2].Value.ToString(),
                        TicketID = Convert.ToInt32(i.Cells[3].Value.ToString()),
                        SeatNo = i.Cells[4].Value.ToString(),
                        TicketPrice = Convert.ToDouble(i.Cells[5].Value.ToString()),
                        Departure = i.Cells[6].Value.ToString(),
                        Destination = i.Cells[7].Value.ToString(),
                        DepartureTime = Convert.ToDateTime(i.Cells[8].Value.ToString()),
                        ArrivalTime = Convert.ToDateTime(i.Cells[9].Value.ToString())
                    };
                    list.Add(s);
                }
                dataGridView1.DataSource = BLLTRAIN.Instance.Sort(list, cbbSort.SelectedIndex, false);
            }
            else
            {
                MessageBox.Show("Chưa chọn thuộc tính sắp xếp!");
                return;
            }
        }
    }
}
