using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;

namespace pbl.View
{
    public partial class GUI : Form
    {
        private Form login;
        private Form form = null;
        private HandlerMyInterfaces handler = new HandlerMyInterfaces(Color.FromArgb(0, 192, 0), Color.FromArgb(0, 140, 0), Color.Green);
        public GUI(Form login, string userName)
        {
            InitializeComponent();
            this.Size = new Size(750, 528);
            labelName.Text = BLLTRAIN.Instance.GetName(userName);
            ShowForm(new note());            
            AddHandler();
            this.login = login;
            PBL3 db = new PBL3();
        }        
        private void CreatForm()
        {
            ShowForm(new note());
            ChangeColor(pHome, null);
        }
        private void ChangeColor(PictureBox p, Button b)
        {
            pHome.BackColor = Color.FromArgb(0, 192, 0);
            //pChat.BackColor = Color.FromArgb(0, 192, 0);
            pTicket.BackColor = Color.FromArgb(0, 192, 0);
            pSchedule.BackColor = Color.FromArgb(0, 192, 0);
            pImage.BackColor = Color.FromArgb(0, 192, 0);
            pArrow.BackColor = Color.FromArgb(0, 192, 0);
            if (p != null) p.BackColor = Color.Green;
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
            //pHome
            this.pHome.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pHome.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            ////pChat
            //this.pChat.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            //this.pChat.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //pTicket
            this.pTicket.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pTicket.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
            //pSchedule
            this.pSchedule.MouseMove += new System.Windows.Forms.MouseEventHandler(handler.Controls_MouseMove);
            this.pSchedule.MouseLeave += new System.EventHandler(handler.Controls_MouseLeave);
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
        }
        private void ShowForm(Form subForm)
        {
            if (form != null) form.Close();
            form = subForm;
            panel_User.Visible = false;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(subForm);
            panel_Content.Tag = subForm;
            subForm.Show();
        }

        private void pHome_Click(object sender, EventArgs e)
        {
            ChangeColor(pHome, null);
            ShowForm(new note());
        }
        private void pChat_Click(object sender, EventArgs e)
        {
            //ChangeColor(pChat, null);
            //ShowForm(new GUIChat());
        }
        private void pTicket_Click(object sender, EventArgs e)
        {
            ChangeColor(pTicket, null);
            ShowForm(new GUITicket());
        }

        private void pSchedule_Click(object sender, EventArgs e)
        {
            ChangeColor(pSchedule, null);
            ShowForm(new GUISchedule());
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
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi hệ thống không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                this.Close();
                login.Show();
            }
        }

        private void GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }
    }
}
