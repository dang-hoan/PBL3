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
    public partial class GUICalendar : Form
    {
        ManageFunction man = new ManageFunction();
        Label[] label = new Label[31];
        HandlerMyInterfaces handler = new HandlerMyInterfaces(Color.Silver, Color.DarkGray, Color.Gray);
        HandlerMyInterfaces handler2 = new HandlerMyInterfaces(Color.FromArgb(0, 192, 0), Color.FromArgb(0, 170, 0), Color.Green);
        public GUICalendar()
        {
            InitializeComponent();
            panel_Detail.Visible = false;
            setLabel();
            init();
        }
        private void setLabel()
        {
            int size = 50;
            int X = 80, Y = 75;
            for(int i = 0; i < 31; i++)
            {
                label[i] = new Label();
                
                //Tên label
                label[i].Text = (i+1).ToString();
                label[i].TextAlign = ContentAlignment.MiddleCenter;

                //Kiểu chữ
                label[i].Font = new Font("Arial", 12f, FontStyle.Bold);

                //Kích thước, vị trí
                label[i].Size = new Size(size, size);
                label[i].Location = new Point(X + size*(i%7), Y + size*(i/7));

                //Trang trí
                label[i].BorderStyle = BorderStyle.FixedSingle;
                label[i].BackColor = Color.Silver;

                //Xử lý sự kiện
                label[i].Click += new EventHandler(label_Click);
                label[i].MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
                label[i].MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);

                this.Controls.Add(label[i]);
            }
            
        }
        private void init()
        {
            for(int i = 1; i  <= 12; i++) cbbMonth.Items.Add(i);
            int now = DateTime.Now.Year;
            for(int i = now - 200; i <= now + 200; i++) cbbYear.Items.Add(i);
        }
        private bool[] hasSchedule = new bool[31];
        private void label_Click(object sender, EventArgs e)
        {
            if (cbbMonth.Text == "" || cbbYear.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ năm tháng!");
                return;
            }
            for(int i = 0; i < 31; i++)
            {
                if(this.label[i].BackColor == Color.Gray)
                {
                    this.label[i].BackColor = Color.Silver;
                }
                if (this.label[i].BackColor == Color.Green)
                {
                    this.label[i].BackColor = Color.FromArgb(0, 192, 0);
                }
            }
            Label label = (Label)sender;
            if(label.BackColor == Color.FromArgb(0, 170, 0))
            {
                label.BackColor = Color.Green;
                labelContent.Text = man.GetSchedule(label.Text, cbbMonth.Text, cbbYear.Text);
                panel_Detail.Visible = true;
            }
            else
            {
                label.BackColor = Color.Gray;
                labelContent.Text = "Ngày này bạn không có lịch trình";
                panel_Detail.Visible = true;
            }
        }
        private void ChangeMonthYear(object sender, EventArgs e)
        {
            DataTable dt = man.GetDepartureTime();
            DateTime key;
            for(int i = 0; i < 31; i++)
            {
                if (hasSchedule[i])
                {
                    label[i].MouseMove -= new System.Windows.Forms.MouseEventHandler(handler2.Controls_MouseMove);
                    label[i].MouseLeave -= new System.EventHandler(handler2.Controls_MouseLeave);
                    label[i].MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
                    label[i].MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
                }
                hasSchedule[i] = false;
            }
            foreach(DataRow i in dt.Rows)
            {
                key = (DateTime)i[0];
                if (key.Month.ToString().Equals(cbbMonth.Text) && key.Year.ToString().Equals(cbbYear.Text))
                {
                    label[key.Day-1].BackColor = Color.FromArgb(0, 192, 0);
                    label[key.Day - 1].MouseMove -= new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
                    label[key.Day - 1].MouseLeave -= new System.EventHandler(handler.Controls_MouseLeave);
                    label[key.Day - 1].MouseMove += new System.Windows.Forms.MouseEventHandler(handler2.Controls_MouseMove);
                    label[key.Day - 1].MouseLeave += new System.EventHandler(handler2.Controls_MouseLeave);
                    hasSchedule[key.Day - 1] = true;
                }
            }
        }
    }
}
