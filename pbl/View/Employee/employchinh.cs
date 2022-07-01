using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.DTO;
using pbl.BLL; 

namespace pbl.View
{
    public partial class Employeechinh : Form
    {
        private Form login;
        public Employeechinh(Form login, string username)
        {
            InitializeComponent();
            this.login = login;
            this.Size = new Size(750, 528);
            this.CenterToScreen();
            showform(CreatForm());
            ten.Text = BLLTRAIN.Instance.GetName(username);
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
        Form form = null;
        private void showform(Form subform)
        {
            if (form != null) form.Close();
            form = subform;
            panel_User.Visible = false;
            subform.TopLevel = false;
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            pnxuly.Controls.Add(subform);
            pnxuly.Tag = subform;
            subform.Show();

         
        }
        private void ChangeColor(PictureBox p, Button b)
        {
            home.BackColor = Color.FromArgb(0, 192, 0);
            khachhang.BackColor = Color.FromArgb(0, 192, 0);
            //pChat.BackColor = Color.FromArgb(0, 192, 0);
            lichtrinh.BackColor = Color.FromArgb(0, 192, 0);
            chuyentau.BackColor = Color.FromArgb(0, 192, 0);
            ve.BackColor = Color.FromArgb(0, 192, 0);
            pictureBox10.BackColor = Color.FromArgb(0, 192, 0);
            pictureBox5.BackColor = Color.FromArgb(0, 192, 0);
            if (p != null) p.BackColor = Color.Green;

            labelPersonal.BackColor = Color.FromArgb(0, 192, 0);
            labelLogOut.BackColor = Color.FromArgb(0, 192, 0);
            //bSetting.BackColor = Color.FromArgb(0, 192, 0);
            if (b != null) b.BackColor = Color.Green;

            labelPersonal.BackColor = Color.FromArgb(0, 192, 0);
        }
        private void khachhang_Click(object sender, EventArgs e)
        {
            showform(new khachhang());
            ChangeColor(khachhang, null);
        }

        private void ve_Click(object sender, EventArgs e)
        {
            showform(new qlve());
            ChangeColor(ve, null);
        }

        private void lichtrinh_Click(object sender, EventArgs e)
        {
            showform(new lichtrinh());
            ChangeColor(lichtrinh, null);
        }

        private void home_Click(object sender, EventArgs e)
        {
            showform(CreatForm());

            ChangeColor(home, null);
            //if (panel_Other.Visible)
            //{
            //    panel_Other.BackColor = Color.FromArgb(0, 192, 0);
            //    panel_Other.Visible = false;
            //}
            //else
            //{
            //    panel_Other.BackColor = Color.Green;
            //    panel_Other.Visible = true;
            //}
        }
        private void pHome_Click(object sender, EventArgs e)
        {
            ChangeColor(null, null);
            labelPersonal.BackColor = Color.Red;
            showform(CreatForm());
        }

        private void canhan(object sender, EventArgs e)
        {
            if (panel_User.Visible) panel_User.Visible = false;
            else panel_User.Visible = true;
        }

        private void labelPersonal_Click(object sender, EventArgs e)
        {
            showform(new GUIPersonal());
        }

        private void labelLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }
        private void setting(object sender, EventArgs e)
        {

            showform(new GUISetting());
        }

        private void pChat_Click(object sender, EventArgs e)
        {
            showform(new train());
            ChangeColor(chuyentau, null);
        }

        private void Employeechinh_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }
    }
}
