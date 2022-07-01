using pbl.BLL;
using pbl.View.Employee;
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
    public partial class Home : Form
    {
        private Form login;
        public Home(Form login)
        {
            InitializeComponent();
            this.login = login;
            this.Size = new Size(1018, 540);
            this.StartPosition = FormStartPosition.CenterScreen;
            labelName.Text = BLLTRAIN.Instance.GetName(GUILogin.userName);
            ShowForm(new note());
        }
        Form f = null;
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
        private void phome_Click(object sender, EventArgs e)
        {
            ShowForm(new note());
            paneltk.Visible=false;
            paneldx.Visible = false;
        }

        private void pnv_Click(object sender, EventArgs e)
        {
            ShowForm(new employee());
            paneltk.Visible = false;
            paneldx.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }

        private void plt_Click(object sender, EventArgs e)
        {
            ShowForm(new Schedule());
            paneldx.Visible = false;
            paneltk.Visible = false;
        }

       
      

      

        private void pttcn_Click(object sender, EventArgs e)
        {
            ShowForm(new Personal());
            paneltk.Visible = false;
            paneldx.Visible = false;
        }

        private void pdt_Click(object sender, EventArgs e)
        {
            ShowForm(new doanhthu());
            paneltk.Visible = false;
            paneldx.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            paneltk.Visible = false;
            if(paneldx.Visible == true)
            {
                paneldx.Visible = false;
            }
            else
            {
                paneldx.Visible = true;
            }
        }

        private void btdx_Click(object sender, EventArgs e)
        {
            this.Close();
            
            login.Show();
        }

        private void dtgname_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow d = dtgtk.Rows[e.RowIndex];
            string Username = d.Cells[0].Value.ToString();

            BLLpeople.instance.Getnvbyuser(Username);


        }

        private void bunifuTextbox1_Click_1(object sender, EventArgs e)
        {
            bunifuTextbox1.text = "";
        }

        private void bunifuTextbox1_OnTextChange_1(object sender, EventArgs e)
        {
            if (bunifuTextbox1.text == "" || bunifuTextbox1.text == "Tìm kiếm nhân viên, khách hàng")
            {
                paneltk.Visible = false;
            }
            else
            {
                paneltk.Visible = true;
                dtgtk.DataSource = BLLpeople.instance.searchtennv(bunifuTextbox1.text);
            }
        }

        private void dtgtk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow d = dtgtk.Rows[e.RowIndex];
            string Username = d.Cells[0].Value.ToString();

            BLLpeople.instance.Getnvbyuser(Username);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowForm(new Notice());
        }
    }
}
