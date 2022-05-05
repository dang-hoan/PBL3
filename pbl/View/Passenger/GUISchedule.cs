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
    public partial class GUISchedule : Form
    {
        Form form;
        public GUISchedule()
        {
            InitializeComponent();
            ShowForm(new GUIPrivateSchedule());
        }
        private void ChangeColor(Button b)
        {
            bPrivate.BackColor = Color.White;
            bSystem.BackColor = Color.White;
            b.BackColor = Color.Gray;
        }
        private void ShowForm(Form subform)
        {
            if (form != null) form.Close();
            form = subform;
            subform.TopLevel = false;
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            panel_Main.Controls.Add(subform);
            panel_Main.Tag = subform;
            subform.Show();
        }

        private void bPrivate_Click(object sender, EventArgs e)
        {
            ChangeColor(bPrivate);
            ShowForm(new GUIPrivateSchedule());
        }

        private void bSystem_Click(object sender, EventArgs e)
        {
            ChangeColor(bSystem);
            ShowForm(new GUISystemSchedule());
        }
    }
}
