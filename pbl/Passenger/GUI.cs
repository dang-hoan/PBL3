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
        HandlerMyInterfaces handler = new HandlerMyInterfaces(Color.FromArgb(0, 192, 0), Color.FromArgb(0, 230, 0), Color.Green);
        ManageFunction man = new ManageFunction();
        public GUI(Form login)
        {
            InitializeComponent();
            this.Size = new Size(750, 528);
            ShowForm(CreatForm());
            this.login = login;
            AddHandler();
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
        private void ChangeColor(PictureBox p, Button b)
        {
            pOther.BackColor = Color.FromArgb(0, 192, 0);
            pHome.BackColor = Color.FromArgb(0, 192, 0);
            pChat.BackColor = Color.FromArgb(0, 192, 0);
            pTicket.BackColor = Color.FromArgb(0, 192, 0);
            pSchedule.BackColor = Color.FromArgb(0, 192, 0);
            pNotify.BackColor = Color.FromArgb(0, 192, 0);
            pImage.BackColor = Color.FromArgb(0, 192, 0);
            pArrow.BackColor = Color.FromArgb(0, 192, 0);
            if (p != null) p.BackColor = Color.Green;

            bHelp.BackColor = Color.FromArgb(0, 192, 0);
            bFeedback.BackColor = Color.FromArgb(0, 192, 0);
            bSetting.BackColor = Color.FromArgb(0, 192, 0);
            if (b != null) b.BackColor = Color.Green;

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
        private void AddHandler()
        {
            //pOther
            this.pOther.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pOther.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //pHome
            this.pHome.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pHome.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //pChat
            this.pChat.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pChat.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //pTicket
            this.pTicket.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pTicket.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //pSchedule
            this.pSchedule.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pSchedule.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //pNotify
            this.pNotify.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pNotify.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //labelName
            this.labelName.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.labelName.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //pImage
            this.pImage.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pImage.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //pArrow
            this.pArrow.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pArrow.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //labelPersonal
            this.labelPersonal.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.labelPersonal.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //labelLogOut
            this.labelLogOut.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.labelLogOut.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            handler.Move = Color.FromArgb(0, 140, 0);
            //bHelp
            this.bHelp.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Button_MouseMove);
            this.bHelp.MouseLeave += new System.EventHandler(handler.Button_MouseLeave);
            //bFeedback
            this.bFeedback.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Button_MouseMove);
            this.bFeedback.MouseLeave += new System.EventHandler(handler.Button_MouseLeave);
            //bSetting
            this.bSetting.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Button_MouseMove);
            this.bSetting.MouseLeave += new System.EventHandler(handler.Button_MouseLeave);
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
            ChangeColor(null, bHelp);
            ShowForm(new GUIHelp());
        }
        private void Feedback_Click(object sender, EventArgs e)
        {
            ChangeColor(null, bFeedback);
            ShowForm(new GUIFeedback());
        }
        private void Setting_Click(object sender, EventArgs e)
        {
            ChangeColor(null,bSetting);
            ShowForm(new GUISetting());
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            ChangeColor(pHome, null);
            ShowForm(CreatForm());
        }
        private void pChat_Click(object sender, EventArgs e)
        {
            ChangeColor(pChat, null);
            ShowForm(new GUIChat());
        }
        private void pTicket_Click(object sender, EventArgs e)
        {
            ChangeColor(pTicket, null);
            ShowForm(new GUITicket());
        }

        private void pSchedule_Click(object sender, EventArgs e)
        {
            ChangeColor(pSchedule, null);
            ShowForm(new GUIMainSchedule());
        }

        private void pNotify_Click(object sender, EventArgs e)
        {
            ChangeColor(pNotify, null);
            ShowForm(new GUINotification());
        }

        private void pArrow_Click(object sender, EventArgs e)
        {
            if(panel_User.Visible) panel_User.Visible = false;
            else panel_User.Visible = true;
        }
        private void CallInfoForm(object sender, EventArgs e)
        {
            ChangeColor(null, null);
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
