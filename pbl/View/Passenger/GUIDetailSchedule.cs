using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;
using pbl.DTO;

namespace pbl
{
    public partial class GUIDetailSchedule : Form
    {
        public GUIDetailSchedule()
        {
            InitializeComponent();
            Init();

            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nl");
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(GUILogin.userName);
            BLLTRAIN.Instance.SetScheduleView(dataGridView1);
        }

        private void Init()
        {
            dateFromDep.Size = new Size(150, 28);
            dateFromDep.Value = DateTime.Now;
            dateToDep.Size = new Size(150, 28);
            dateToDep.Value = DateTime.Now;
            dateFromDes.Size = new Size(150, 28);
            dateFromDes.Value = DateTime.Now;
            dateToDes.Size = new Size(150, 28);
            dateToDes.Value = DateTime.Now;
            List<string> listDep = new List<string>();
            List<string> listDes = new List<string>();
            BLLTRAIN.Instance.GetStation(GUILogin.userName, ref listDep, ref listDes);
            foreach (string s in listDep)
            {
                cbbDep.Items.Add(s);
            }
            foreach (string s in listDes)
            {
                cbbDes.Items.Add(s);
            }
        }

        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            cbbDes.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDestination(GUILogin.userName, cbbDep.Text))
            {
                cbbDes.Items.Add(s);
            }
        }

        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            cbbDep.Items.Clear();
            foreach (string s in BLLTRAIN.Instance.GetDeparture(GUILogin.userName, cbbDes.Text))
            {
                cbbDep.Items.Add(s);
            }
        }

        private void bShowAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(GUILogin.userName);
        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(dateFromDep.Value, dateToDep.Value);
            int comp2 = DateTime.Compare(dateFromDes.Value, dateToDes.Value);
            int comp3 = DateTime.Compare(dateFromDep.Value, dateFromDes.Value);
            if (comp > 0 || comp2 > 0)
            {
                if (comp > 0 && comp2 > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến  (trong cả ngày đi và ngày đến)!");
                else if (comp > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đi)!");
                else MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đến)!");
                return;
            }
            if (comp3 >= 0)
            {
                MessageBox.Show("Mốc thời gian từ trong ngày đến tối thiểu phải sau mốc thời gian từ trong ngày đi!");
                return;
            }
            SCHEDULE_BLL s = new SCHEDULE_BLL
            {
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                FromDepartureTime = dateFromDep.Value,
                ToDepartureTime = dateToDep.Value,
                FromArrivalTime = dateFromDes.Value,
                ToArrivalTime = dateToDes.Value
            };
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s, GUILogin.userName);
        }
        private void cbbStation_Leave(object sender, EventArgs e)
        {
            ComboBox cbb = (ComboBox)sender;
            if(cbb.Text != "")
            {
                foreach(object i in cbb.Items)
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
        public int[] numberChar = new int[5] { 17, 25, 25, 30, 30 };
        private void pSave_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.Print(dataGridView1, numberChar,"Lịch trình cá nhân", this);
        }
    }
}
