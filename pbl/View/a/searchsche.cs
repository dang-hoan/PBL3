using pbl.BLL;
using pbl.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl.View.Admin
{
    public partial class searchsche : Form
    {
        public searchsche()
        {
            InitializeComponent();
            Init();
            //Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nl");
            dateFromDep.MinDate = DateTime.Now;
            dateFromDep.MaxDate = DateTime.Now.AddYears(100);
            dateToDep.MinDate = DateTime.Now;
            dateToDep.MaxDate = DateTime.Now.AddYears(100);
            dateFromDes.MinDate = DateTime.Now;
            dateFromDes.MaxDate = DateTime.Now.AddYears(100);
            dateToDes.MinDate = DateTime.Now;
            dateToDes.MaxDate = DateTime.Now.AddYears(100);
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
       
        private void Init()
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
        }
        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDestination(cbbDep.Text).Distinct())
            {
                cbbDes.Items.Add(s);
            }
        }
        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDeparture(cbbDes.Text).Distinct())
            {
                cbbDep.Items.Add(s);
            }
        }
        private void cbbStation_Leave(object sender, EventArgs e)
        {
            ComboBox cbb = (ComboBox)sender;
            if (cbb.Text != "")
            {
                foreach (object i in cbb.Items)
                {
                    if (i.ToString().Equals(cbb.Text))
                    {
                        return;
                    }
                }
                ((ComboBox)sender).Text = "";
                MessageBox.Show("Ga bạn nhập không tồn tại hoặc không phù hợp với lịch trình!");
            }
        }

        private void bTOK_Click(object sender, EventArgs e)
        {
            
                int comp = DateTime.Compare(dateFromDep.Value, dateToDep.Value);
                int comp2 = DateTime.Compare(dateFromDes.Value, dateToDes.Value);
                if (comp > 0 || comp2 > 0)
                {
                    if (comp > 0 && comp2 > 0) MessageBox.Show("Mốc thời gian đến phải lớn hơn mốc thời gian từ (trong cả ngày đi và ngày đến)!");
                    else if (comp > 0) MessageBox.Show("Mốc thời gian đến phải lớn hơn mốc thời gian từ (trong ngày đi)!");
                    else MessageBox.Show("Mốc thời gian đến phải lớn hơn mốc thời gian từ (trong ngày đến)!");
                    return;
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
                    ScheduleID = "",
                    Departure = cbbDep.Text,
                    Destination = cbbDes.Text,
                    FromDepartureTime = dateFromDep.Value,
                    ToDepartureTime = dateToDep.Value,
                    FromArrivalTime = dateFromDes.Value,
                    ToArrivalTime = dateToDes.Value
                };
                dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s);

            }
       
        }
}
