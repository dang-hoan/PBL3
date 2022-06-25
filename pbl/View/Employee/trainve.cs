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
    public partial class trainve : Form
    {
        public  delegate void mydel(int scheduleid, int trainid);
        public mydel d;
        public trainve()
        {
            InitializeComponent();
            gui();
        }
        public void gui()
        {
            SCHEDULE_BLL s = new SCHEDULE_BLL
            {
                ScheduleID = -1,
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
            };
            dataGridView1.DataSource = BLLTRAIN.Instance.GetTrain3(s);
        }

    }
    }

