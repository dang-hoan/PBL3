﻿using System;
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
    public partial class GUICalendar : Form
    {
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
            int X = 30, Y = 75;
            for (int i = 0; i < 31; i++)
            {
                label[i] = new Label();

                //Tên label
                label[i].Text = (i + 1).ToString();
                label[i].TextAlign = ContentAlignment.MiddleCenter;

                //Kiểu chữ
                label[i].Font = new Font("Arial", 12f, FontStyle.Bold);

                //Kích thước, vị trí
                label[i].Size = new Size(size, size);
                label[i].Location = new Point(X + size * (i % 7), Y + size * (i / 7));

                //Trang trí
                label[i].BorderStyle = BorderStyle.FixedSingle;
                label[i].BackColor = Color.Silver;

                //Xử lý sự kiện
                label[i].Click += new EventHandler(label_Click);
                label[i].MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
                label[i].MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
                label[i].Cursor = Cursors.Hand;

                this.Controls.Add(label[i]);
            }

        }
        private void init()
        {
            for (int i = 1; i <= 12; i++) cbbMonth.Items.Add(i);
            int now = DateTime.Now.Year;
            for (int i = now - 200; i <= now + 200; i++) cbbYear.Items.Add(i);
        }
        private bool[] hasSchedule = new bool[31];
        private void label_Click(object sender, EventArgs e)
        {
            if (cbbMonth.Text == "" || cbbYear.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ năm tháng!");
                return;
            }
            for (int i = 0; i < 31; i++)
            {
                if (this.label[i].BackColor == Color.Gray)
                {
                    this.label[i].BackColor = Color.Silver;
                }
                if (this.label[i].BackColor == Color.Green)
                {
                    this.label[i].BackColor = Color.FromArgb(0, 192, 0);
                }
            }
            Label label = (Label)sender;
            if (hasSchedule[Convert.ToInt32(label.Text) - 1])
            {
                label.BackColor = Color.Green;
                labelContent.Text = BLLTRAIN.Instance.GetSchedule(GUILogin.userName, label.Text, cbbMonth.Text, cbbYear.Text);
                panel_Detail.Visible = true;
            }
            else
            {
                label.BackColor = Color.Gray;
                labelContent.Text = $"\nNgày {label.Text}/{cbbMonth.Text}/{cbbYear.Text} bạn không có lịch trình";
                panel_Detail.Visible = true;
            }
        }
        private int[] numberDayOf = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private void ChangeMonthYear(object sender, EventArgs e)
        {
            if(cbbYear.Text == "" || cbbMonth.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ năm tháng!");
                return;
            }
            panel_Detail.Visible = false;

            int year = Convert.ToInt32(cbbYear.Text);
            if (year % 4 == 0 || (year % 100 == 0 && year % 400 == 0)) numberDayOf[1] = 29;
            else numberDayOf[1] = 28;
            for (int i = 1; i < numberDayOf[Convert.ToInt32(cbbMonth.Text) - 1] + 1; i++)
            {
                label[i - 1].Visible = true;
            }
            for (int i = numberDayOf[Convert.ToInt32(cbbMonth.Text)-1]+1; i <= 31; i++){
                label[i - 1].Visible = false;
            }

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
                label[i].BackColor = Color.Silver;
            }
            foreach(int i in BLLTRAIN.Instance.GetDayOfDepartureTime(cbbMonth.Text, cbbYear.Text, GUILogin.userName))
            {
                if (!hasSchedule[i - 1])
                {
                    label[i - 1].BackColor = Color.FromArgb(0, 192, 0);
                    label[i - 1].MouseMove -= new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
                    label[i - 1].MouseLeave -= new System.EventHandler(handler.Controls_MouseLeave);
                    label[i - 1].MouseMove += new System.Windows.Forms.MouseEventHandler(handler2.Controls_MouseMove);
                    label[i - 1].MouseLeave += new System.EventHandler(handler2.Controls_MouseLeave);
                    hasSchedule[i - 1] = true;
                }
            }
        }

        private void GUICalendar_Click(object sender, EventArgs e)
        {
            panel_Detail.Visible = false;
        }

        private void GUICalendar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChangeMonthYear(sender, e);
            }
        }
    }
}