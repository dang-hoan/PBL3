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

namespace pbl
{
    public partial class GUIOption : Form
    {
        DateTimePicker dateFromDep = new DateTimePicker();
        DateTimePicker dateToDep = new DateTimePicker();
        DateTimePicker dateFromDes = new DateTimePicker();
        DateTimePicker dateToDes = new DateTimePicker();
        public delegate void MyDel(SCHEDULE_BLL s);
        public MyDel d { get; set; }
        public GUIOption(SCHEDULE_BLL s)
        {
            InitializeComponent();
            Init(s);
        }
        private void Init(SCHEDULE_BLL s)
        {
            cbbDep.Text = s.Departure;
            cbbDes.Text = s.Destination;
            List<CBBSchedule> listDep = new List<CBBSchedule>();
            List<CBBSchedule> listDes = new List<CBBSchedule>();
            BLLTRAIN.Instance.GetStation(GUILogin.userName, ref listDep, ref listDes);
            foreach (CBBSchedule sch in listDep)
            {
                cbbDep.Items.Add(sch);
            }
            foreach (CBBSchedule sch in listDes)
            {
                cbbDes.Items.Add(sch);
            }

            //Khởi tạo thuộc tính DateTimePicker dateDep và dateDes
            dateFromDep.Size = new Size(137, 28);
            dateFromDep.TabIndex = 25;
            dateFromDep.Parent = this;
            dateFromDep.Location = new Point(113, label3.Location.Y - 2);
            dateFromDep.Format = DateTimePickerFormat.Custom;
            dateFromDep.CustomFormat = "dd/MM/yyyy HH:mm";
            dateFromDep.Value = s.FromDepartureTime;

            dateToDep.Size = new Size(137, 28);
            dateToDep.TabIndex = 25;
            dateToDep.Parent = this;
            dateToDep.Location = new Point(310, label3.Location.Y - 2);
            dateToDep.Format = DateTimePickerFormat.Custom;
            dateToDep.CustomFormat = "dd/MM/yyyy HH:mm";
            dateToDep.Value = s.ToDepartureTime;

            dateFromDes.Size = new Size(137, 28);
            dateFromDes.TabIndex = 26;
            dateFromDes.Parent = this;
            dateFromDes.Location = new Point(113, label4.Location.Y - 2);
            dateFromDes.Format = DateTimePickerFormat.Custom;
            dateFromDes.CustomFormat = "dd/MM/yyyy HH:mm";
            dateFromDes.Value = s.FromArrivalTime;

            dateToDes.Size = new Size(137, 28);
            dateToDes.TabIndex = 26;
            dateToDes.Parent = this;
            dateToDes.Location = new Point(310, label4.Location.Y - 2);
            dateToDes.Format = DateTimePickerFormat.Custom;
            dateToDes.CustomFormat = "dd/MM/yyyy HH:mm";
            dateToDes.Value = s.ToArrivalTime;
        }
        private void bAccept_Click(object sender, EventArgs e)
        {
            int comp = DateTime.Compare(dateFromDep.Value, dateToDep.Value);
            int comp2 = DateTime.Compare(dateFromDes.Value, dateToDes.Value);
            int comp3 = DateTime.Compare(dateFromDep.Value, dateFromDes.Value);
            if (comp > 0 || comp2 > 0)
            {
                if(comp > 0 && comp2 > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong cả ngày đi và ngày đến)!");
                else if(comp > 0) MessageBox.Show("Mốc thời gian từ không thể trước mốc thời gian đến (trong ngày đi)!");
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
                ScheduleID = -1,
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
                FromDepartureTime = dateFromDep.Value,
                ToDepartureTime = dateToDep.Value,
                FromArrivalTime = dateFromDes.Value,
                ToArrivalTime = dateToDes.Value
            };
            d(s);
            this.Close();
        }
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cbbDep_TextChanged(object sender, EventArgs e)
        {
            //cbbDep.Items.Clear();
            //cbbDep.Items.AddRange(BLLTRAIN.Instance.GetDeparture2(GUILogin.userName, cbbDep.Text).Distinct().ToArray());
            cbbDes.Items.Clear();
            int rep = (cbbDep.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDep.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDestination(GUILogin.userName, rep))
                cbbDes.Items.Add(s);
        }

        private void cbbDes_TextChanged(object sender, EventArgs e)
        {
            //cbbDes.Items.Clear();
            //cbbDes.Items.AddRange(BLLTRAIN.Instance.GetDestination2(GUILogin.userName, cbbDes.Text).Distinct().ToArray());
            cbbDep.Items.Clear();
            int rep = (cbbDes.SelectedItem == null) ? -1 : (int)((CBBSchedule)cbbDes.SelectedItem).Value;
            foreach (CBBSchedule s in BLLTRAIN.Instance.GetDeparture(GUILogin.userName, rep))
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
    }
}
