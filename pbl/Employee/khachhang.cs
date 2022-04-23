using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public partial class khachhang : Form
    {
        public khachhang()
        {
            InitializeComponent();
        }

        private void infor_Load(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
             addkhachhang f = new addkhachhang();
            f.Show();
        }
    }
}
