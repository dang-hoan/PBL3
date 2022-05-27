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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Blue;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home!");
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
