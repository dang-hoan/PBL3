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
    public partial class GUISchedule : Form
    {
        ManageFunction man = new ManageFunction();
        public GUISchedule()
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
        }
        private void bShow_Click(object sender, EventArgs e)
        {
            string DepTime, DesTime;
            DepTime = dateDep.Value.ToString("yyyy/MM/dd ") + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            DesTime = dateDes.Value.ToString("yyyy/MM/dd ") + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
            if (cbbHourDep.Text == "" || cbbMinuteDep.Text == "")
            {
                DepTime = dateDep.Value.ToString("yyyy/MM/dd ");
            }
            if (cbbHourDes.Text == "" || cbbMinuteDes.Text == "")
            {
                DesTime = dateDes.Value.ToString("yyyy/MM/dd ");
            }
            MessageBox.Show(DepTime + DesTime);
            dataGridView1.DataSource = man.GetSchedule(GUI.userName, cbbDep.Text, cbbDes.Text, rbOne.Checked||!rbRound.Checked, DepTime, DesTime);
        }
    }
}
