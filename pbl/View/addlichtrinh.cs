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

namespace pbl.View
{
    public partial class addlichtrinh : Form
    {
        public delegate void Mydel();
        public Mydel d { get; set; }
        public addlichtrinh()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            cbbDep.Items.AddRange(BLLTRAIN.Instance.Getstation().ToArray());
            cbbDes.Items.AddRange(BLLTRAIN.Instance.Getstation().ToArray());
        }

        private void bTOK_Click(object sender, EventArgs e)
        {
            int comp = string.Compare(daydep.Value.ToString("yyyy/MM/dd HH:mm"), daydes.Value.ToString("yyyy/MM/dd HH:mm"));
            if (comp >= 0)
            {
                MessageBox.Show("Thời gian đến phải sau thời gian đi!");
                return;
            }
            string date1 = daydep.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            if (string.Compare(date1, now) < 0 )
            {
                MessageBox.Show("Lịch trình phải có thời gian bắt đầu từ thời điểm hiện tại!");
                return;
            }
            if(cbbDep.Text == "" || cbbDes.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin lịch trình!");
                return;
            }
            else
            {
                SCHEDULE s = new SCHEDULE
                {
                    ScheduleID = -1,
                    DepartureID = ((CBBSchedule)(cbbDep.SelectedItem)).Value,
                    ArrivalID = ((CBBSchedule)(cbbDes.SelectedItem)).Value,
                    DepartureTime = daydep.Value,
                    ArrivalTime = daydes.Value,

                };
                if (!BLLTRAIN.Instance.CheckSchedule(s))
                {
                    BLLTRAIN.Instance.Execute(s);
                    MessageBox.Show("Đã thêm lịch trình vào hệ thống thành công!");
                    d();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lịch trình bạn chọn đã tồn tại trong hệ thống!");
                }   
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void hourdep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbDep_Click(object sender, EventArgs e)
        {
            string temp = cbbDep.Text;
            cbbDep.Items.Clear();
            int rep = (cbbDes.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDes.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetAllStation(rep))
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
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetAllStation(rep))
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
