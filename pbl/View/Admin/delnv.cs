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

namespace pbl.View.Admin
{
    public partial class delnv : Form
    {
        public delnv()
        {
            InitializeComponent();
            shownv();
        }
        public void shownv()
        {

            dataGridView1.DataSource = BLLpeople.instance.getallnv(222);
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    BLLpeople.instance.delperson(row.Cells["Username"].Value.ToString());
                }
            }
            shownv();
        }
    }
    
}
