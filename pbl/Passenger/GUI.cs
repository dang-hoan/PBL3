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
        Form form = null;
        public GUI()
        {
            InitializeComponent();
            this.Size = new Size(750, 550);
            this.CenterToScreen();
            ShowForm(CreatForm());
        }        
        private Form CreatForm()
        {
            Form GUIHome = new Form();
            PictureBox picture = new PictureBox();

            GUIHome.Size = new Size(1096, 689);
            picture.Width = 730;
            picture.Height = 470;
            Bitmap image = new Bitmap(@"C:\PBL3\pbl\picture\text.png");
            picture.Image = (Image)image;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

            GUIHome.Controls.Add(picture);
            return GUIHome;
        }
        private void ChangeColor(PictureBox p)
        {
            pOther.BackColor = Color.FromArgb(0, 192, 0);
            pHome.BackColor = Color.FromArgb(0, 192, 0);
            pChat.BackColor = Color.FromArgb(0, 192, 0);
            pTicket.BackColor = Color.FromArgb(0, 192, 0);
            pSchedule.BackColor = Color.FromArgb(0, 192, 0);
            pNotify.BackColor = Color.FromArgb(0, 192, 0);
            pArrow.BackColor = Color.FromArgb(0, 192, 0);
            p.BackColor = Color.Green;
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
                ChangeColor(pOther);
                panel_Other.Visible = true;
            }
        }
        private void pHome_Click(object sender, EventArgs e)
        {
            ChangeColor(pHome);
            ShowForm(CreatForm());
        }
        private void pChat_Click(object sender, EventArgs e)
        {
            ChangeColor(pChat);
            ShowForm(new GUIChat());
        }
        private void pTicket_Click(object sender, EventArgs e)
        {
            ChangeColor(pTicket);
            ShowForm(new GUITicket());
        }

        private void pSchedule_Click(object sender, EventArgs e)
        {
            ChangeColor(pSchedule);
            ShowForm(new GUIMainSchedule());
        }

        private void pNotify_Click(object sender, EventArgs e)
        {
            ChangeColor(pNotify);
            ShowForm(new GUINotification());
        }

        private void pArrow_Click(object sender, EventArgs e)
        {
            if(panel_User.Visible) panel_User.Visible = false;
            else panel_User.Visible = true;
        }
        private void CallInfoForm(object sender, EventArgs e)
        {
            ShowForm(new GUIPersonal());
        }

    }
}
