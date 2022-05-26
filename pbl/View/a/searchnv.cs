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
    public partial class searchnv : Form
    {
        public searchnv()
        {
            InitializeComponent();
            shownv();
        }
        public void shownv()
        {

            dataGridView1.DataSource = BLLpeople.instance.getallnv("222");
        }

    }
    
}
