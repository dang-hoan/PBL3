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
    public partial class GUIBook : Form
    {
        ManageFunction man = new ManageFunction();
        int numberOfCarriages = 25;
        Image imageLeft1 = (Image)new Bitmap(@"C:\PBL3\picture\play (1) - Copy.png"), imageRight1 = (Image)new Bitmap(@"C:\PBL3\picture\play (1).png");
        Image imageLeft2 = (Image)new Bitmap(@"C:\PBL3\picture\play1.png"), imageRight2 = (Image)new Bitmap(@"C:\PBL3\picture\play.png");
        private string Departure, Destination, DepartureTime, DestinationTime;
        private bool Type;
        public GUIBook()
        {
            InitializeComponent();
            Init();
            dataGridView1.DataSource = man.GetAllTicket();
        }
        private void Init()
        {
            DataTable dt = man.GetTrain().DefaultView.ToTable(true, "TrainName");
            foreach (DataRow dr in dt.Rows)
            {
                cbbTrain.Items.Add(dr[0]);
            }
            pLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(pLeft_MouseMove);
            pLeft.MouseLeave += new System.EventHandler(pLeft_MouseLeave);
            pRight.MouseMove += new System.Windows.Forms.MouseEventHandler(pRight_MouseMove);
            pRight.MouseLeave += new System.EventHandler(pRight_MouseLeave);
        }
        private void Get(string Departure, string Destination, bool Type, string DepartureTime, string DestinationTime)
        {
            this.Departure = Departure;
            this.Destination = Destination;
            this.Type = Type;
            this.DepartureTime = DepartureTime;
            this.DestinationTime = DestinationTime;
        }
        private void Schedule_Click(object sender, EventArgs e)
        {
            GUIOption option = new GUIOption();
            option.d += new GUIOption.MyDel(Get);
            option.Show();
        }
        private void bBook_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                for(int i = 0; i < dataGridView1.SelectedRows.Count; i++){
                    DataGridViewRow dt = dataGridView1.SelectedRows[i];
                    if (dt.Cells["Booked"].Value.ToString() == "true")
                    {
                        MessageBox.Show("Vé có mã là " + dt.Cells["TicketID"].Value.ToString() +" đã có người đặt!");
                    }
                    else
                    {
                        man.SetTicket(dt.Cells["TicketID"].Value.ToString(), GUI.userName, true);
                    }
                }
                MessageBox.Show("Đã đặt thành công những vé bạn chọn!");
                Reload();
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTrain_SelectedIndexChanged(object sender, EventArgs e)
        {            
            DataTable dt = man.GetNumberOfCarriages(cbbTrain.SelectedIndex);
            numberOfCarriages = Convert.ToInt32(dt.Rows[0][0].ToString());
        }
        private void ChangeLocation(Label lab)
        {
            if(lab.Text == "9" || lab.Text == "10")
            {
                int x = (pRight.Location.X - pLeft.Location.X - pLeft.Size.Width - labelCarriage.Size.Width) / 2;
                Point poi = lab.Location;
                poi.X = pLeft.Location.X + pLeft.Size.Width + x;
                lab.Location = poi;
            }
        }
        private void pLeft_Click(object sender, EventArgs e)
        {
            if (labelCarriage.Text == "1") return;
            labelCarriage.Text = (Convert.ToInt32(labelCarriage.Text)-1).ToString();
            ChangeLocation(labelCarriage);
        }

        private void pRight_Click(object sender, EventArgs e)
        {
            if (labelCarriage.Text == numberOfCarriages.ToString()) return;
            labelCarriage.Text = (Convert.ToInt32(labelCarriage.Text) + 1).ToString();
            ChangeLocation(labelCarriage);
        }
        private void pLeft_MouseMove(object sender, EventArgs e)
        {
            pLeft.Image = imageLeft2;
        }
        private void pLeft_MouseLeave(object sender, EventArgs e)
        {
            pLeft.Image = imageLeft1;
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            labelCarriage.Text = man.GetNumberBooked(cbbTrain.SelectedIndex, Departure, Destination, Type, DepartureTime, DestinationTime).ToString();
            Reload();            
        }
        private void Reload()
        {
            dataGridView1.DataSource = man.GetTicket(Departure, Destination, Type, DepartureTime, DestinationTime, cbbTrain.SelectedIndex, labelCarriage.Text);
        }

        private void pRight_MouseMove(object sender, EventArgs e)
        {
            pRight.Image = imageRight2;
        }
        private void pRight_MouseLeave(object sender, EventArgs e)
        {
            pRight.Image = imageRight1;
        }
    }
}
