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
    public partial class GUIOption : Form
    {
        ManageFunction man = new ManageFunction();
        public delegate void MyDel(string Departure, string Destination, bool Type, string DepartureTime, string DestinationTime);
        public MyDel d { get; set; }
        public GUIOption()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {
            DataTable dt = man.GetStation();
            foreach(DataRow dr in dt.Rows)
            {
                cbbDep.Items.Add(dr[0]);
                cbbDes.Items.Add(dr[0]);
            }
            for(int i = 0; i < 24; i++)
            {
                cbbHourDep.Items.Add(i);
                cbbHourDes.Items.Add(i);
            }
            for (int i = 0; i < 60; i++)
            {
                cbbMinuteDep.Items.Add(i);
                cbbMinuteDes.Items.Add(i);
            }
        }

        private void bAccept_Click(object sender, EventArgs e)
        {
            if(cbbDep.Text == "" || cbbDes.Text == "" || !rbOne.Checked && !rbRound.Checked)
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin yêu cầu!");
                return;
            }
            string DepTime, DesTime;
            DepTime = dateDep.Value.ToString("yyyy/MM/dd ") + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            DesTime = dateDes.Value.ToString("yyyy/MM/dd ") + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
            if (cbbHourDep.Text == "" || cbbMinuteDep.Text == "")
            {
                DepTime = dateDep.Value.ToString("yyyy/MM/dd ");
            }
            if(cbbHourDes.Text == "" || cbbMinuteDes.Text == "")
            {
                DesTime = dateDes.Value.ToString("yyyy/MM/dd ");
            }
            d(cbbDep.Text, cbbDes.Text, rbOne.Checked || !rbRound.Checked, DepTime, DesTime);
            this.Close();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
