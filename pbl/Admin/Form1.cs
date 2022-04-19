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
        private void ChangeColor(PictureBox p)
        {
            potheradmin.BackColor = Color.FromArgb(0, 192, 0);
            pHome.BackColor = Color.FromArgb(0, 192, 0);
            //pChat.BackColor = Color.FromArgb(0, 192, 0);
           // pTicket.BackColor = Color.FromArgb(0, 192, 0);
            pSchedule.BackColor = Color.FromArgb(0, 192, 0);
           // pNotify.BackColor = Color.FromArgb(0, 192, 0);
           // pArrow.BackColor = Color.FromArgb(0, 192, 0);
            p.BackColor = Color.Green;
        }
        private void pOther_Click(object sender, EventArgs e)
        {
            if (panel_Other.Visible)
            {
                potheradmin.BackColor = Color.FromArgb(0, 192, 0);
                panel_Other.Visible = false;
            }
            else
            {
                ChangeColor(potheradmin);
                panel_Other.Visible = true;
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowForm(new employee());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowForm(new schedule());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowForm(new Passenger());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            ShowForm(new note());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
