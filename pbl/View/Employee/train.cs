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
    public partial class train : Form
    {
     
        public train()
        {
            InitializeComponent();
            gui();
        }
        public void gui()
        {
            dateFromDep.Value = DateTime.Now;
            dateToDep.Value = DateTime.Now;
            dateFromDes.Value = DateTime.Now;
            dateToDes.Value = DateTime.Now;
            List<string> listDep = new List<string>();
            List<string> listDes = new List<string>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach (string s in listDep.Distinct())
            {
                cbbDep.Items.Add(s);
            }
            foreach (string s in listDes.Distinct())
            {
                cbbDes.Items.Add(s);
            }
          

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(dateFromDep.Value, dateToDep.Value);
            int comp2 = DateTime.Compare(dateFromDes.Value, dateToDes.Value);
            int comp3 = DateTime.Compare(dateFromDep.Value, dateToDes.Value);
            if (comp > 0 || comp2 > 0)
            {
                if (comp > 0 && comp2 > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong cả ngày đi và ngày đến)!");
                else if (comp > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đi)!");
                else MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đến)!");
                return;
            }
            if (comp3 >= 0)
            {
                MessageBox.Show("Mốc thời gian đến trong ngày đến tối thiểu phải sau mốc thời gian từ trong ngày đi!");
            }
            string date1 = dateFromDep.Value.ToString("yyyy/MM/dd HH:mm");
            string date2 = dateToDep.Value.ToString("yyyy/MM/dd HH:mm");
            string date3 = dateFromDes.Value.ToString("yyyy/MM/dd HH:mm");
            string date4 = dateToDes.Value.ToString("yyyy/MM/dd HH:mm");
            string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
            if (string.Compare(date1, now) < 0 || string.Compare(date2, now) < 0 || string.Compare(date3, now) < 0 || string.Compare(date4, now) < 0)
            {
                MessageBox.Show("Lịch trình phải có thời gian bắt đầu từ thời điểm hiện tại!");
                return;
            }
            SCHEDULE_BLL s = new SCHEDULE_BLL
            {
                ScheduleID = -1,
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                FromDepartureTime = dateFromDep.Value,
                ToDepartureTime = dateToDep.Value,
                FromArrivalTime = dateFromDes.Value,
                ToArrivalTime = dateToDes.Value
            };
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTrain2(s);
        }

        private void buttrain_Click(object sender, EventArgs e)
        {
            addtrain f = new addtrain(0);
            f.Show();
            f.d = new addtrain.Mydel(show);

        }

        private void butall_Click(object sender, EventArgs e)
        {
            show();

        }
        public void show()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.Getalltrain();
        }
        public void show2(string s)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.Getalltrain();
        }

        private void butve_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int trainid = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TrainID"].Value.ToString());
               addve f = new addve(trainid);
                f.Show();
                f.d = new addve.Mydel(show2);
                MessageBox.Show("thêm thành công vé tàu mới ");
            }
            else
                MessageBox.Show(" vui lòng chọn một lịch trình!");

        }

        private void butdelte_Click(object sender, EventArgs e)
        { 
            if (dataGridView1.SelectedRows.Count > 0) { }
        }
    }
}
