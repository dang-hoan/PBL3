﻿using pbl.Admin;
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
    public partial class Schedule : Form
    {
        public Schedule()
        {
            
            InitializeComponent();
            showsche("");
        }

        public void showsche(string Pos)
        {
            Pos = "111";
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
        private void btaddschedule_Click(object sender, EventArgs e)
        {
            addschedule a = new addschedule();
            a.Show();
            a.d = new addschedule.Mydel(showsche);

        }
        
        
    }
}