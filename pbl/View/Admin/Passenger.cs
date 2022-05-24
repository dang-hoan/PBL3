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
    public partial class Passenger : Form
    {
        public Passenger()
        {
            InitializeComponent();
            showpass("333");
        }
        public void deltxt()
        {
            
            txtsearch.Text = "";
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLpeople.instance.searchem(txtsearch.Text);
        }
        public void showpass(string PositionId)
        {
            dataGridView1.DataSource = BLLpeople.instance.getallnv(PositionId);
        }

        private void txtsearch_MouseClick(object sender, MouseEventArgs e)
        {
            deltxt();
        }
    }
}
