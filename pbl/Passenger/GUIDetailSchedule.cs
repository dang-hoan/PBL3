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
    public partial class GUIDetailSchedule : Form
    {
        ManageFunction man = new ManageFunction();
        public GUIDetailSchedule()
        {
            InitializeComponent();
            Init();
            dataGridView1.DataSource = man.GetSchedule(GUI.userName);
        }

        private void Init()
        {
            DataTable dt = man.GetStation(GUI.userName);
            foreach(DataRow dr in dt.Rows)
            {
                cbbDep.Items.Add(dr[0].ToString());
                cbbDes.Items.Add(dr[1].ToString());
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
            dateDep.Text = "";
            dateDes.Text = "";
        }
        private void bShow_Click(object sender, EventArgs e)
        {
            bool hasInputDep = false;
            bool hasInputDes = false;
            string DepTime, DesTime;
            DepTime = dateDep.Value.ToString("yyyy/MM/dd");
            DesTime = dateDes.Value.ToString("yyyy/MM/dd");
            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
                hasInputDep = true;
            }
            else if (cbbHourDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + "0";
                hasInputDep = true;
            }
            if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
                hasInputDes = true;
            }
            else if (cbbHourDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + "0";
                hasInputDes = true;
            }
            dataGridView1.DataSource = man.GetSchedule(GUI.userName, cbbDep.Text, cbbDes.Text, rbOne.Checked||!rbRound.Checked, DepTime, DesTime, hasInputDep, hasInputDes);
        }

        private void cbbDep_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Remove(cbbDep.Text);
        }

        private void cbbDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Remove(cbbDes.Text);
        }
    }
}
