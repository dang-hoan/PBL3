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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form f=null;
        //tao form moi tren form cu
        private void ShowForm(Form subForm)
        {
            if (f != null) f.Close();
            f = subForm;
            panel_Other.Visible = false;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(subForm);
            panel_Content.Tag = subForm;
            subForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowForm(new employee());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowForm(new Schedule());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowForm(new Passenger());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            ShowForm(new note());
        }
    }
}
