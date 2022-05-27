using pbl.BLL;
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
    public partial class delsche : Form
    {
        public delsche()
        {
            InitializeComponent();
            showsche();
        }
        public void showsche()
        {
           dataGridView1.DataSource= BLLTRAIN.Instance.GetSchedule();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    BLLTRAIN.Instance.delsche(Convert.ToInt32(row.Cells["ScheduleID"].Value));
                }
            }
        }
    }
}
