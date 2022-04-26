using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl.Passenger
{
    public partial class GUISystemSchedule : Form
    {
        ManageFunction man = new ManageFunction();
        public GUISystemSchedule()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            DataTable dt = man.GetStation(GUI.userName);
            foreach (DataRow dr in dt.Rows)
            {
                cbbDep.Items.Add(dr[0].ToString());
                cbbDes.Items.Add(dr[1].ToString());
            }
            for (int i = 0; i <= 23; i++)
            {
                cbbHourDep.Items.Add(i);
                cbbHourDes.Items.Add(i);
            }
            for (int i = 0; i <= 59; i++)
            {
                cbbMinuteDep.Items.Add(i);
                cbbMinuteDes.Items.Add(i);
            }
            dateDep.Text = "";
            dateDes.Text = "";
        }
        private void bShow_Click(object sender, EventArgs e)
        {
            string DepTime, DesTime;
            DepTime = dateDep.Value.ToString("yyyy/MM/dd");
            DesTime = dateDes.Value.ToString("yyyy/MM/dd");
            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            }
            if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
            }
            dataGridView1.DataSource = man.GetSchedule(cbbDep.Text, cbbDes.Text, rbOne.Checked || !rbRound.Checked, DepTime, DesTime);
        }

        private void bBook_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count >= 1)
            {   
                GUIBook book = new GUIBook();
                book.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn tối thiểu một lịch trình để đặt vé!");
            }
            
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
