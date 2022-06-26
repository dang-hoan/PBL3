﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nl");
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(GUILogin.userName);
            BLLTRAIN.Instance.SetScheduleView(dataGridView1);
        }

        private void Init()
        {
            dateFromDep.Size = new Size(150, 28);
            dateFromDep.Value = DateTime.Now;
            dateToDep.Size = new Size(150, 28);
            dateToDep.Value = DateTime.Now;
            dateFromDes.Size = new Size(150, 28);
            dateFromDes.Value = DateTime.Now;
            dateToDes.Size = new Size(150, 28);
            dateToDes.Value = DateTime.Now;
            List<CBBSchedule> listDep = new List<CBBSchedule>();
            List<CBBSchedule> listDes = new List<CBBSchedule>();
            BLLTRAIN.Instance.GetStation(GUILogin.userName, ref listDep, ref listDes);
            foreach (CBBSchedule s in listDep)
            {
                cbbDep.Items.Add(s);
            }
            foreach (CBBSchedule s in listDes)
            {
                cbbDes.Items.Add(s);
            }
        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(GUILogin.userName);
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(dateFromDep.Value, dateToDep.Value);
            int comp2 = DateTime.Compare(dateFromDes.Value, dateToDes.Value);
            int comp3 = DateTime.Compare(dateFromDep.Value, dateFromDes.Value);
            if (comp > 0 || comp2 > 0)
            {
                if (comp > 0 && comp2 > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến  (trong cả ngày đi và ngày đến)!");
                else if (comp > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đi)!");
                else MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đến)!");
                return;
            }
            if (comp3 >= 0)
            {
                MessageBox.Show("Mốc thời gian từ trong ngày đến tối thiểu phải sau mốc thời gian từ trong ngày đi!");
                return;
            }
            SCHEDULE_BLL s = new SCHEDULE_BLL
            {
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                FromDepartureTime = dateFromDep.Value,
                ToDepartureTime = dateToDep.Value,
                FromArrivalTime = dateFromDes.Value,
                ToArrivalTime = dateToDes.Value
            };
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s, GUILogin.userName);
        }
        public int[] numberChar = new int[5] { 17, 25, 25, 30, 30 };
        private void pSave_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.Print(dataGridView1, numberChar,"Lịch trình cá nhân");
        }

        private void cbbDep_Click(object sender, EventArgs e)
        {
            string temp = cbbDep.Text;
            cbbDep.Items.Clear();
            int rep = (cbbDes.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDes.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDeparture(GUILogin.userName, rep))
            {
                cbbDep.Items.Add(s);
            }
            for (int i = 0; i < cbbDep.Items.Count; i++)
            {
                if (cbbDep.Items[i].ToString().Equals(temp))
                {
                    cbbDep.SelectedIndex = i;
                    break;
                }
            }

        }

        private void cbbDes_Click(object sender, EventArgs e)
        {
            string temp = cbbDes.Text;
            cbbDes.Items.Clear();
            int rep = (cbbDep.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDep.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDestination(GUILogin.userName, rep))
            {
                cbbDes.Items.Add(s);
            }
            for (int i = 0; i < cbbDes.Items.Count; i++)
            {
                if (cbbDes.Items[i].ToString().Equals(temp))
                {
                    cbbDes.SelectedIndex = i;
                    break;
                }
            }

        }
    }
}
