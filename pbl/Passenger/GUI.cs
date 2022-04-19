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
    public partial class GUI : Form
    {
        Form login;
        Form form = null;
        public GUI(Form login)
        {
            InitializeComponent();
            this.Size = new Size(750, 528);
            this.CenterToScreen();
            ShowForm(CreatForm());
            this.login = login;
        }        
        private Form CreatForm()
        {
            Form GUIHome = new Form();
            PictureBox picture = new PictureBox();

            GUIHome.Size = new Size(1096, 689);
            picture.Width = 730;
            picture.Height = 470;
            Bitmap image = new Bitmap(@"C:\PBL3\picture\text.png");
            picture.Image = (Image)image;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            GUIHome.Controls.Add(picture);
            return GUIHome;
        }
        private void ChangeColor(PictureBox p)
        {           
            
        }
        private void ChangeColor(PictureBox p, PictureBox pi, Label l, Panel pa, bool Different)
        {
            pOther.BackColor = Color.FromArgb(0, 192, 0);
            pHome.BackColor = Color.FromArgb(0, 192, 0);
            pChat.BackColor = Color.FromArgb(0, 192, 0);
            pTicket.BackColor = Color.FromArgb(0, 192, 0);
            pSchedule.BackColor = Color.FromArgb(0, 192, 0);
            pNotify.BackColor = Color.FromArgb(0, 192, 0);
            pArrow.BackColor = Color.FromArgb(0, 192, 0);
            if (p != null) p.BackColor = Color.Green;

            pHelp.BackColor = Color.FromArgb(0, 192, 0);
            labelHelp.BackColor = Color.FromArgb(0, 192, 0);
            panelHelp.BackColor = Color.FromArgb(0, 192, 0);
            pFeedback.BackColor = Color.FromArgb(0, 192, 0);
            labelFeedback.BackColor = Color.FromArgb(0, 192, 0);
            panelFeedback.BackColor = Color.FromArgb(0, 192, 0);
            pSetting.BackColor = Color.FromArgb(0, 192, 0);
            labelSetting.BackColor = Color.FromArgb(0, 192, 0);
            panelSetting.BackColor = Color.FromArgb(0, 192, 0);
            if (Different)
            {
                pi.BackColor = Color.Green;
                l.BackColor = Color.Green;
                pa.BackColor = Color.Green;
            }

            labelPersonal.BackColor = Color.FromArgb(0, 192, 0);
        }
        private void DocFill()
        {
            //pOther.Dock = DockStyle.Fill;
            //pHome.Dock = DockStyle.Fill;
            //pChat.Dock = DockStyle.Fill;
            //pTicket.Dock = DockStyle.Fill;
            //pSchedule.Dock = DockStyle.Fill;
            //pNotify.Dock = DockStyle.Fill;
            //pArrow.Dock = DockStyle.Fill;
        }
        private void ShowForm(Form subForm)
        {
            if (form != null) form.Close();
            form = subForm;
            panel_Other.Visible = false;
            panel_User.Visible = false;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(subForm);
            panel_Content.Tag = subForm;
            subForm.Show();
        }
        private void pOther_Click(object sender, EventArgs e)
        {
            if (panel_Other.Visible)
            {
                pOther.BackColor = Color.FromArgb(0, 192, 0);
                panel_Other.Visible = false;
            }
            else
            {
                pOther.BackColor = Color.Green;
                panel_Other.Visible = true;
            }
        }
        private void Help_Click(object sender, EventArgs e)
        {
            ChangeColor(null, pHelp, labelHelp, panelHelp, true);
            ShowForm(new GUIHelp());
        }
        private void Feedback_Click(object sender, EventArgs e)
        {
            ChangeColor(null, pFeedback, labelFeedback, panelFeedback, true);
            ShowForm(new GUIFeedback());
        }
        private void Setting_Click(object sender, EventArgs e)
        {
            ChangeColor(null, pSetting, labelSetting, panelSetting, true);
            ShowForm(new GUISetting());
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            ChangeColor(pHome, null, null, null, false);
            ShowForm(CreatForm());
        }
        private void pChat_Click(object sender, EventArgs e)
        {
            ChangeColor(pChat, null, null, null, false);
            ShowForm(new GUIChat());
        }
        private void pTicket_Click(object sender, EventArgs e)
        {
            ChangeColor(pTicket, null, null, null, false);
            ShowForm(new GUITicket());
        }

        private void pSchedule_Click(object sender, EventArgs e)
        {
            ChangeColor(pSchedule, null, null, null, false);
            ShowForm(new GUIMainSchedule());
        }

        private void pNotify_Click(object sender, EventArgs e)
        {
            ChangeColor(pNotify, null, null, null, false);
            ShowForm(new GUINotification());
        }

        private void pArrow_Click(object sender, EventArgs e)
        {
            if(panel_User.Visible) panel_User.Visible = false;
            else panel_User.Visible = true;
        }
        private void CallInfoForm(object sender, EventArgs e)
        {
            ChangeColor(null, null, null, null, false);
            labelPersonal.BackColor = Color.Green;
            ShowForm(new GUIPersonal());
        }
        private void labelLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

    }
}
