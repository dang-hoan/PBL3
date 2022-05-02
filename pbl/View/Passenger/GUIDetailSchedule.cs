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
    public partial class GUIDetailSchedule : Form
    {
        public GUIDetailSchedule()
        {
            InitializeComponent();
            Init();
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(GUILogin.userName);//.Distinct();
        }

        private void Init()
        {
            List<string> listDep = new List<string>();
            List<string> listDes = new List<string>();
            BLLTRAIN.Instance.GetStation(GUILogin.userName, ref listDep, ref listDes);
            foreach (string s in listDep.Distinct())
            {
                cbbDep.Items.Add(s);
            }
            foreach (string s in listDes.Distinct())
            {
                cbbDes.Items.Add(s);
            }
            for (int i = 0; i <= 23; i++)
            {
                cbbHourDep.Items.Add(i);
                cbbHourDes.Items.Add(i);
            }
            for(int i = 0; i <= 59; i++)
            {
                cbbMinuteDep.Items.Add(i);
                cbbMinuteDes.Items.Add(i);
            }
        }

        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Clear();
            if (cbbDep.Text != "")
            {
                foreach (string s in BLLTRAIN.Instance.GetDestination(GUILogin.userName).Distinct())
                {
                    cbbDes.Items.Add(s);
                }
                cbbDes.Items.Remove(cbbDep.Text);
            }
            else
            {
                foreach (string s in BLLTRAIN.Instance.GetDestination(GUILogin.userName).Distinct())
                {
                    cbbDes.Items.Add(s);
                }
            }
        }

        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Clear();
            if (cbbDes.Text != "")
            {
                foreach (string s in BLLTRAIN.Instance.GetDeparture(GUILogin.userName).Distinct())
                {
                    cbbDep.Items.Add(s);
                }
                cbbDep.Items.Remove(cbbDes.SelectedItem);
            }
            else
            {
                foreach (string s in BLLTRAIN.Instance.GetDeparture(GUILogin.userName).Distinct())
                {
                    cbbDep.Items.Add(s);
                }
            }
        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(GUILogin.userName).Distinct();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string DepTime, DesTime;
            DepTime = dateDep.Value.ToString("d/m/yyyy");
            DesTime = dateDes.Value.ToString("d/m/yyyy");
            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            }
            if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
            }
            SCHEDULE s = new SCHEDULE
            {
                ScheduleID = "",
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                DepartureTime = DepTime,
                ArrivalTime = DesTime
            };
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s, GUILogin.userName).Distinct();
        }
    }
}
