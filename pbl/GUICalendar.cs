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
        Label[] label = new Label[31];
        public GUICalendar()
        {
            InitializeComponent();
            panel_Detail.Visible = false;
            setLabel();
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
                label[i].BackColor = Color.White;

                this.Controls.Add(label[i]);
            }
            label[7].BackColor = Color.Green;
            label[7].Click += new EventHandler(label_Click);
        }
        private void label_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BackColor = Color.DarkGreen;
            panel_Detail.Visible = true;
            labelContent.Text = "Ga đi: Hà Nội\nGa đến: Đà Nẵng\nThời gian đi: 12:00 15/04/2022\nThời gian đến: 15:00 16/04/2022";
        }
    }
}
