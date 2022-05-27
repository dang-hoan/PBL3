using pbl.Admin;
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
    public partial class Mainform : Form
    {
        private Form login;
        
        
        public Mainform(Form login)
        {
            InitializeComponent();
            this.login = login;
            anpanel();
        }
        
        Form f = null;
        public void anpanel()
        {
            panelqllt.Visible = false;
            panelqlnv.Visible = false;
            
        }
        private void ShowForm(Form subForm)
        {
            if (f != null) f.Close();
            f = subForm;

            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panelmain.Controls.Add(subForm);
            panelmain.Tag = subForm;
            subForm.Show();
        }
        public void hide()
        {
            if (panelqlnv.Visible == true)
            {
                panelqlnv.Visible = false;
            }
            if (panelqllt.Visible == true)
            {
                panelqllt.Visible = false;
            }
        }
        public void showpanel(Panel p)
        {
            if (p.Visible == false)
            {
                p.Visible = true;
            }
            else
            {
                p.Visible = false;
            }
        }

        private void btqlnv_Click(object sender, EventArgs e)
        {
            hide();
            ShowForm(new employee());
            showpanel(panelqlnv);
        }

        private void btqllt_Click(object sender, EventArgs e)
        {
            hide();
            ShowForm(new Schedule());
            showpanel(panelqllt);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShowForm(new Passenger());
        }

        private void btaddsche_Click(object sender, EventArgs e)
        {
            ShowForm(new addschedule());
        }

        private void btsearchsche_Click(object sender, EventArgs e)
        {
            ShowForm(new searchsche());
        }

       

        private void btaddnv_Click(object sender, EventArgs e)
        {
            ShowForm(new addnv());
           
        }

        private void btupdatenv_Click(object sender, EventArgs e)
        {
            ShowForm(new updatenv());

        }

        private void bttimkiemnv_Click(object sender, EventArgs e)
        {

            ShowForm(new searchnv());
        }
    }
}
