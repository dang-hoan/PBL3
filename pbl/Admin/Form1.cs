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
        Form login;
        public Form1(Form login)
        {
            InitializeComponent();
            
            this.login = login;
            
        }
        Form f=null;
        //tao form moi tren form cu
        private void ShowForm(Form subForm)
        {
            if (f != null) f.Close();
            f = subForm;
            
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(subForm);
            panel_Content.Tag = subForm;
            subForm.Show();
        }
        private void ChangeColor(PictureBox p)
        {
            
            pHome.BackColor = Color.FromArgb(0, 192, 0);
            //pChat.BackColor = Color.FromArgb(0, 192, 0);
           // pTicket.BackColor = Color.FromArgb(0, 192, 0);
            pSchedule.BackColor = Color.FromArgb(0, 192, 0);
           // pNotify.BackColor = Color.FromArgb(0, 192, 0);
           // pArrow.BackColor = Color.FromArgb(0, 192, 0);
            p.BackColor = Color.Green;
        }
        private void pArrow_Click(object sender, EventArgs e)
        {
            if (paneluser.Visible) paneluser.Visible = false;
            else paneluser.Visible = true;
        }
        
       

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            ShowForm(new note());
        }


        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ShowForm(new GUIPersonal());
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void lcanhan_Click(object sender, EventArgs e)
        {
            ShowForm(new GUIPersonal());
        }

        private void lbqlnv_Click(object sender, EventArgs e)
        {
            ShowForm(new employee());
        }

        private void pqlnv_Click(object sender, EventArgs e)
        {
            ShowForm(new employee());
        }

        private void lblichtrinh_Click(object sender, EventArgs e)
        {
            ShowForm(new Schedule());
        }

        private void pSchedule_Click(object sender, EventArgs e)
        {
            ShowForm(new Schedule());
        }

        private void lbkhachhang_Click(object sender, EventArgs e)
        {
            ShowForm(new Passenger());
        }
       

        private void lkhachhang_Click(object sender, EventArgs e)
        {
            ShowForm(new Passenger());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Close();
        }

        private void lbtrangchu_Click(object sender, EventArgs e)
        {
            ShowForm(new note());
        }
    }
}
