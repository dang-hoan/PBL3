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
    public partial class GUIBook2 : Form
    {
        int numberOfCarriages = 25;
        Image imageLeft1 = (Image)new Bitmap(@"C:\PBL3\picture\play (1) - Copy.png"), imageRight1 = (Image)new Bitmap(@"C:\PBL3\picture\play (1).png");
        Image imageLeft2 = (Image)new Bitmap(@"C:\PBL3\picture\play1.png"), imageRight2 = (Image)new Bitmap(@"C:\PBL3\picture\play.png");
        private List<int> list = null;
        public GUIBook2(List<int> list)
        {
            InitializeComponent();
            this.list = list;
            Init();
            sortA.BackColor = Color.White;
            sortZ.BackColor = Color.White;
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(list);
            BLLTRAIN.Instance.SetTicketView(dataGridView1);
        }
        private void Init()
        {
            cbbTrain.Items.Add("Tất cả");
            cbbTrain.Items.AddRange(BLLTRAIN.Instance.GetTrain(list).ToArray());
            pLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(pLeft_MouseMove);
            pLeft.MouseLeave += new System.EventHandler(pLeft_MouseLeave);
            pRight.MouseMove += new System.Windows.Forms.MouseEventHandler(pRight_MouseMove);
            pRight.MouseLeave += new System.EventHandler(pRight_MouseLeave);
            cbbSort.Items.AddRange(new string[]
            {
                "Mã lịch trình", "Mã tàu", "Tên tàu", "Mã vé", "Số ghế", "Giá vé"
                , "Ga đi", "Ga đến", "Thời gian đi", "Thời gian đến", "Trạng thái", "Tên đăng nhập chủ", "Tên chủ"
            });
        }
        private void bBook_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                List<int> arr = new List<int>();
                List<int> arr2 = new List<int>();
                for(int i = 0; i < dataGridView1.SelectedRows.Count; i++){
                    DataGridViewRow dt = dataGridView1.SelectedRows[i];
                    if (dt.Cells["Booked"].Value.ToString().Equals("đã đặt"))
                    {
                        arr.Add(Convert.ToInt32(dt.Cells["TicketID"].Value.ToString()));
                    }
                    else
                    {
                        arr2.Add(Convert.ToInt32(dt.Cells["TicketID"].Value.ToString()));
                        BLLTRAIN.Instance.SetTicket(Convert.ToInt32(dt.Cells["TicketID"].Value.ToString()), GUILogin.userName, true);
                    }
                }
                string s1 = "", s2 = "";
                if (arr.Count != 0)
                {
                    for (int i = 0; i < arr.Count - 1; i++) s1 += arr[i].ToString() + ",  ";
                    s1 += arr[arr.Count - 1].ToString();
                    MessageBox.Show("Các vé có mã là " + s1 + " đã có người đặt!");
                }
                if(arr2.Count != 0)
                {
                    for (int i = 0; i < arr2.Count - 1; i++) s2 += arr2[i].ToString() + ",  ";
                    s2 += arr2[arr2.Count - 1].ToString();
                    MessageBox.Show($"Đã đặt thành công các vé có mã là {s2}!");
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
            sortA.BackColor = Color.White;
            sortZ.BackColor = Color.White;
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
            sortA.BackColor = Color.White;
            sortZ.BackColor = Color.White;
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTicket(list, TrainName, Convert.ToInt32(labelCarriage.Text), ref booked, ref unbooked);
            labelBooked.Text = booked.ToString();
            labelUnbooked.Text = unbooked.ToString();
        }
        public int[] numberChar = new int[13] { 14, 10, 25, 8, 14, 25, 25, 25, 30, 30, 8, 20, 40 };
        private void pSave_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.Print(dataGridView1, numberChar,"Vé hệ thống");
        }

        private void labelCarriage_Click(object sender, EventArgs e)
        {

        }

        private void pRight_MouseMove(object sender, EventArgs e)
        {
            pRight.Image = imageRight2;
        }
        private void pRight_MouseLeave(object sender, EventArgs e)
        {
            pRight.Image = imageRight1;
        }
        private void sortA_Click(object sender, EventArgs e)
        {
            if (cbbSort.Text != "")
            {
                sortA.BackColor = Color.Green;
                sortZ.BackColor = Color.White;
                List<TICKET_View> list = dataGridView1.DataSource as List<TICKET_View>;
                dataGridView1.DataSource = BLLTRAIN.Instance.SortSystem(list, cbbSort.SelectedIndex, true);
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
                List<TICKET_View> list = dataGridView1.DataSource as List<TICKET_View>;
                dataGridView1.DataSource = BLLTRAIN.Instance.SortSystem(list, cbbSort.SelectedIndex, false);
            }
            else
            {
                MessageBox.Show("Chưa chọn thuộc tính sắp xếp!");
                return;
            }
        }
    }
}
