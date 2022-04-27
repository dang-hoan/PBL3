using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public partial class GUITicket : Form
    {
        ManageFunction man = new ManageFunction();
        private string Departure, Destination, DepartureTime, DestinationTime;
        private bool Type, hasInputDep, hasInputDes;
        private bool clickSchedule = false;
        public GUITicket()
        {
            InitializeComponent();
            Init();
            dataGridView1.DataSource = man.GetAllTicket(GUI.userName);
        }
        private void Init()
        {
            DataTable dt = man.GetTrain().DefaultView.ToTable(true, "TrainName");
            foreach (DataRow dr in dt.Rows)
            {
                cbbTrain.Items.Add(dr[0]);
            }
        }

        private void Get(string Departure, string Destination, bool Type, string DepartureTime, string DestinationTime, bool hasInputDep, bool hasInputDes)
        {
            this.Departure = Departure;
            this.Destination = Destination;
            this.Type = Type;
            this.DepartureTime = DepartureTime;
            this.DestinationTime = DestinationTime;
            this.hasInputDep = hasInputDep;
            this.hasInputDes = hasInputDes;
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
                        man.SetTicket(i.Cells["TicketID"].Value.ToString(), GUI.userName, false);
                    }
                    MessageBox.Show("Đã huỷ những vé bạn chọn!");
                    Reload();
                }
            }
        }
        private void Reload()
        {
            if (clickSchedule)
                dataGridView1.DataSource = man.GetTicket(GUI.userName, Departure, Destination, Type, DepartureTime, DestinationTime, cbbTrain.SelectedIndex, "", hasInputDep, hasInputDes);
            //else
            //    dataGridView1.DataSource = man.GetTicket(cbbTrain.SelectedIndex);
        }
        private void Schedule_Click(object sender, EventArgs e)
        {
            clickSchedule = true;
            GUIOption option = new GUIOption();
            option.d += new GUIOption.MyDel(Get);
            option.Show();
        }
        private void bSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = man.GetAllTicket(GUI.userName);
        }
    }
}
