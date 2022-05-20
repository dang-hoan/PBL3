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
        }
    
        private void butall_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }

        private void butdelte_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    BLLTRAIN.Instance.delschedule(row.Cells["scheduleid"].Value.ToString());
                }
            }

        }

        private void themlt_Click(object sender, EventArgs e)
        {
            addlichtrinh f = new addlichtrinh("");
            f.Show();

        }

        private void butmuave_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    list.Add(dr.Cells["ScheduleID"].Value.ToString());
                }
                GUIBook book = new GUIBook(list);
                book.Show();
            }
            else
            {
                MessageBox.Show("Hãy chọn tối thiểu một lịch trình để đặt vé!");
            }
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            string DepTime, DesTime;
            DateTime dep, des;
            dep = dateDep.Value;
            des = dateDes.Value;
            int HourDep = (cbbHourDep.Text == "")? 0 : Convert.ToInt32(cbbHourDep.Text);
            int hourdes = (cbbHourDes.Text == "")? 0 : Convert.ToInt32(cbbHourDes.Text);
            DesTime = dateDes.Value.ToString("d/M/yyyy");
            DepTime = dateDep.Value.ToString("d/M/yyyy");
            if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            {
                DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            }
            if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
            {
                DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
            }
            int comp = string.Compare(dep.ToString("dd/MM/yyyy"), des.ToString("dd/MM/yyyy"));
            if (comp > 0)
            {
                MessageBox.Show("Ngày đến phải sau ngày đi!"); 
            }
            else if (comp == 0)
            {
                if (HourDep > hourdes)
                    MessageBox.Show("Thời gian đến phải sau thời gian đi!");
            }
            else
            {
                SCHEDULE_View s = new SCHEDULE_View()
                {
                    Departure = cbbDep.Text,    
                    Destination = cbbDes.Text,
                    DepartureTime = DepTime,
                    ArrivalTime = DesTime,
                };

                dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s);

            }
        }


        //private void themlt_Click(object sender, EventArgs e)
        //{
        //    addlichtrinh f = new addlichtrinh(" ");
        //    f.Show();
        //    f.d = new addkhachhang.Mydel(show);
        //}
    }
}
