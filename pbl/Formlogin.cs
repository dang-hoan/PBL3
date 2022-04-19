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
            else if(txtusername.Text == "2")
            {
                nhanvien f = new nhanvien();
                f.ShowDialog();
            }
            else if(txtusername.Text == "3" )
            {
                GUI g=new GUI();
                g.ShowDialog();
            }

               
        }
    }
}
