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
    public partial class GUIBook : Form
    {
        int numberOfCarriages = 25;
        Image imageLeft1 = (Image)new Bitmap(@"C:\PBL3\picture\play (1) - Copy.png"), imageRight1 = (Image)new Bitmap(@"C:\PBL3\picture\play (1).png");
        Image imageLeft2 = (Image)new Bitmap(@"C:\PBL3\picture\play1.png"), imageRight2 = (Image)new Bitmap(@"C:\PBL3\picture\play.png");
        private List<string> list = null;
        public GUIBook(List<string> list)
        {
            InitializeComponent();
            this.list = list;
            Init();
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(list);
        }
        private void Init()
        {
            cbbTrain.Items.Add("Tất cả");
            cbbTrain.Items.AddRange(BLLTRAIN.Instance.GetTrain(list).Distinct().ToArray());
            pLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(pLeft_MouseMove);
            pLeft.MouseLeave += new System.EventHandler(pLeft_MouseLeave);
            pRight.MouseMove += new System.Windows.Forms.MouseEventHandler(pRight_MouseMove);
            pRight.MouseLeave += new System.EventHandler(pRight_MouseLeave);
        }
        private void bBook_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                for(int i = 0; i < dataGridView1.SelectedRows.Count; i++){
                    DataGridViewRow dt = dataGridView1.SelectedRows[i];
                    if (dt.Cells["Booked"].Value.ToString().Equals("True"))
                    {
                        MessageBox.Show("Vé có mã là " + dt.Cells["TicketID"].Value.ToString() +" đã có người đặt!");
                    }
                    else
                    {
                        BLLTRAIN.Instance.SetTicket(dt.Cells["TicketID"].Value.ToString(), GUILogin.userName, true);
                        MessageBox.Show($"Đã đặt thành công vé có mã {dt.Cells["TicketID"].Value.ToString()}!");
                    }
                }
                Reload();
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            string TrainName = "";
            if(cbbTrain.Text != "Chọn một tàu" && cbbTrain.Text != "Tất cả") TrainName = cbbTrain.Text;
            numberOfCarriages = BLLTRAIN.Instance.GetNumberOfCarriages(TrainName);
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

        private void bSearch_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(list);
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
        private void Reload()
        {
            string TrainName = ""; int booked = 0, unbooked = 0;
            if (cbbTrain.Text != "Chọn một tàu" && cbbTrain.Text != "Tất cả") TrainName = cbbTrain.Text;
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(list, TrainName, Convert.ToInt32(labelCarriage.Text), ref booked, ref unbooked);
            labelBooked.Text = booked.ToString();
            labelUnbooked.Text = unbooked.ToString();
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
