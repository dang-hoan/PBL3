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
            HandlerMyInterfaces handler = new HandlerMyInterfaces(Color.Gray, Color.Silver, Color.DarkGray);
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
                label[i].BackColor = Color.Gray;

                //Xử lý sự kiện
                label[i].Click += new EventHandler(label_Click);
                label[i].MouseMove += new MouseEventHandler(handler.Controls_MouseMove);
                label[i].MouseLeave += new EventHandler(handler.Controls_MouseLeave);

                this.Controls.Add(label[i]);
            }
            
        }
        private void init()
        {
            for(int i = 1; i  <= 12; i++) cbbMonth.Items.Add(i);
            int now = DateTime.Now.Year;
            for(int i = now - 200; i <= now + 200; i++) cbbYear.Items.Add(i);
        }
        private void label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            for(int i = 0; i < this.label.Length; i++)
            {
                this.label[i].BackColor = Color.White;
            }
            label.BackColor = Color.DarkGreen;
            labelContent.Text = man.GetSchedule(label.Text, cbbMonth.Text, cbbYear.Text);//"Ga đi: Hà Nội\nGa đến: Đà Nẵng\nThời gian đi: 12:00 15/04/2022\nThời gian đến: 15:00 16/04/2022";
            panel_Detail.Visible = true;
        }
        private void ChangeMonthYear(object sender, EventArgs e)
        {
            DataTable dt = man.GetDepartureTime();
            string date = cbbYear.Text + "/" + cbbMonth.Text + "/";
            string dateCSDL; DateTime d;
            foreach (DataRow i in dt.Rows)
            {
                d = (DateTime)i[0];
                dateCSDL = d.ToString("yyyy/MM/dd");
                if (dateCSDL.Contains(date))
                {
                    label[d.Day].BackColor = Color.Green;
                }
            }
        }
    }
}
