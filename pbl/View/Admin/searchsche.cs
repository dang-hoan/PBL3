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
        }
        public void showsche()
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule();
        }

        private void bTOK_Click(object sender, EventArgs e)
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
}
