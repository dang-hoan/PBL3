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
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            if( txtusername.Text == "1" )
            {
                  Form1 form1 = new Form1();
                  form1.ShowDialog();
            }
            else
            {
                GUI g=new GUI();
                g.ShowDialog();
            }

               
        }
    }
}
