using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.DTO;
using pbl.BLL;

namespace pbl.View
{
    public partial class lichtrinh : Form
    {
        public lichtrinh()
        {
            InitializeComponent();
            gui();
        }
        public void gui()
        {
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
            //for (int i = 0; i <= 23; i++)
            //{
            //    cbbHourDep.Items.Add(i);
            //    cbbHourDes.Items.Add(i);
            //}
            //for (int i = 0; i <= 59; i++)
            //{
            //    cbbMinuteDep.Items.Add(i);
            //    cbbMinuteDes.Items.Add(i);
            //}
        }
       public void show ()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
        private void butall_Click(object sender, EventArgs e)
        {
            show();
        }

        private void butdelte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    BLLTRAIN.Instance.delschedule(row.Cells["ScheduleID"].Value.ToString());
                }
            }
            show();
        }

        private void themlt_Click(object sender, EventArgs e)
        {
            addlichtrinh f = new addlichtrinh("");
           
            f.d = new addlichtrinh.Mydel(show);
            f.Show();
        }

    
        private void bSearch_Click(object sender, EventArgs e)
        {

            string DepTime, DesTime;
            DateTime dep, des;
//<<<<<<< HEAD
           
//            //DepTime = dateDep.Value.ToString("d/M/yyyy");
//            //if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
//            //{
//            //    DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
//            //}
           
//         //   else
//=======
//            dep = dateDep.Value;
//            des = dateDes.Value;
//            int HourDep = (cbbHourDep.Text == "")? 0 : Convert.ToInt32(cbbHourDep.Text);
//            int hourdes = (cbbHourDes.Text == "")? 0 : Convert.ToInt32(cbbHourDes.Text);
//            DesTime = dateDes.Value.ToString("dd/MM/yyyy");
//            DepTime = dateDep.Value.ToString("dd/MM/yyyy");
//            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
//            {
//                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
//            }
//            if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
//            {
//                DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
//            }
//            int comp = string.Compare(dep.ToString("dd/MM/yyyy"), des.ToString("dd/MM/yyyy"));
//            if (comp > 0)
//            {
//                MessageBox.Show("Ngày đến phải sau ngày đi!"); 
//            }
//            else if (comp == 0)
//            {
//                if (HourDep > hourdes)
//                    MessageBox.Show("Thời gian đến phải sau thời gian đi!");
//            }
//            else
//>>>>>>> 17fe53d13b4b7954edbc1bee6df0822c370df0a8
            {
                SCHEDULE_View s = new SCHEDULE_View()
                {
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                   // DepartureTime = DepTime,
                };

                dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule2(s);
               
            }
        }

        private void buttrain_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string scheduleid = dataGridView1.SelectedRows[0].Cells["ScheduleID"].Value.ToString();
                addtrain f = new addtrain(scheduleid);
                f.Show();
            }
            else
            MessageBox.Show(" vui lòng chọn một lịch trình!");
            
        }
    }
}
