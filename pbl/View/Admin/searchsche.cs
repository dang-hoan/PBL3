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
            showsche();
            cbb();
        }
        public void showsche()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }
        public void cbb()
        {
            List<string> list = new List<string>();
            list = BLLTRAIN.Instance.Getstation();
            foreach (string s in list)
            {
                cbbDep.Items.Add(s);
            }
            foreach (string s in list)
            {
                cbbDes.Items.Add(s);
            }
        }

        private void bTOK_Click(object sender, EventArgs e)
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
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s);
            
        }
    }
}
