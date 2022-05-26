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

namespace pbl.View
{
    public partial class addtrain : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public int trainid, scheduleid;
        public addtrain(int s)
        {
            InitializeComponent();
            if (schedule.Text != "") label1.Visible = false;
            else label1.Visible = true;
            trainid = s;
            Init();
            schedule.Enabled = false;
            cbbDep.Enabled = false;
            cbbDes.Enabled = false;
        }
        PBL3 db = new PBL3();
        private void Init()
        {
            foreach (SCHEDULE i in BLLTRAIN.Instance.GetScheduleid(trainid))
            {
                schedule.Text = i.ScheduleID.ToString();
                schedule.Enabled = false;
                cbbDep.Text = i.Departure;
                cbbDep.Enabled = false;
                cbbDes.Text = i.Destination;
                cbbDes.Enabled = false;
            }
            List<string> name = new List<string>();
            foreach (CBBpeople s in BLLTRAIN.Instance.GetAllCBBDriver())
            {
                cbblaixe.Items.Add(s);
            }
            if (schedule.Text != "") label1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bTOK_Click(object sender, EventArgs e)
        {
            if (schedule.Text == "")
            {
                MessageBox.Show("chon mot lich trinh truoc khi ok!");
            }
            if ( (txtname.Text == "") || (txtsotoa.Text == "") || (cbblaixe.Text == "")||(schedule.Text==""))
            {
                MessageBox.Show("bạn chưa nhập đủ dư liệu bắt buộc ");
            }
            else
            {
                TRAIN s = new TRAIN
                {
                    ScheduleID = Convert.ToInt32(schedule.Text),
                    TrainName = txtname.Text,
                    NumberOfCarriages = int.Parse(txtsotoa.Text),
                    DriverUN = ((CBBpeople)cbblaixe.SelectedItem).Value,
                    BasicPrice = decimal.Parse(txtgiagoc.Text),
                };
                BLLTRAIN.Instance.Executetrain(s);
                d();
                this.Close();
            }

           
        }
        private void getScheduleID(int scheduleid)
        {
            label1.Visible = false;
            foreach (SCHEDULE i in BLLTRAIN.Instance.GetScheduleid(scheduleid))
            {
                schedule.Text = i.ScheduleID.ToString();
                cbbDep.Text = i.Departure;
                cbbDes.Text = i.Destination;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lich_trinh_Click(object sender, EventArgs e)
        {
            if (trainid == -1)
            {
                lichtrinadd f = new lichtrinadd();
                f.Show();
                f.d = new lichtrinadd.MyDel(getScheduleID);
            }
            else MessageBox.Show("da chon lich trinh truoc do!");
        }

     
    }
}