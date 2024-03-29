﻿
using System;
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


namespace pbl.View
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            
            InitializeComponent();
            cbb(); 
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nl");
            showsche();
        }
        

        public void showsche()
        {
            dtg.DataSource = BLLTRAIN.Instance.GetSchedule2();
        }
        public void cbb()
        {
            List<CBBSchedule> listDep = new List<CBBSchedule>();
            List<CBBSchedule> listDes = new List<CBBSchedule>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach (CBBSchedule s in listDep) cbbDep.Items.Add(s);
            foreach (CBBSchedule s in listDes) cbbDes.Items.Add(s);
        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            showsche();
        }

        private void cbbDep_Click(object sender, EventArgs e)
        {
            string temp = cbbDep.Text;
            cbbDep.Items.Clear();
            int rep = (cbbDes.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDes.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDeparture2(rep))
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
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDestination2(rep))
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

        private void bAdd_Click(object sender, EventArgs e)
        {
            addlichtrinh f = new addlichtrinh();
            f.d = new addlichtrinh.Mydel(showsche);
            f.Show();
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(dateDep.Value, dateDes.Value);
            if (comp > 0)
            {
                MessageBox.Show("Thời gian đi phải  trước mốc thời gian đến !");
                return;
            }


            dtg.DataSource = BLLTRAIN.Instance.GetSchedulead(dateDep.Value.ToString("d/M/yyyy"),
                dateDes.Value.ToString("d/M/yyyy"), cbbDep.Text, cbbDes.Text);
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            if (dtg.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dtg.SelectedRows.Count; i++)
                    BLLTRAIN.Instance.DeleteSchedule(Convert.ToInt32(dtg.SelectedRows[i].Cells[0].Value.ToString()));
                MessageBox.Show("Đã xoá thành công các lịch trình bạn chọn!");
                showsche();
            }
            else MessageBox.Show("Hãy chọn ít nhất 1 lịch trình để xoá!");
        }
    }
}
