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
    public partial class searchnv : Form
    {
        public searchnv()
        {
            InitializeComponent();
            shownv(222);
        }
        public void deltxt()
        {

            txtsearch.Text = "";
        }
        public void shownv(int PositionId)
        {
            dataGridView1.DataSource = BLLpeople.instance.getallnv(PositionId);
        }
        private void btsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLpeople.instance.searchnv(txtsearch.Text);
        }

        private void txtsearch_MouseClick(object sender, MouseEventArgs e)
        {
            deltxt();
        }
    }
}
