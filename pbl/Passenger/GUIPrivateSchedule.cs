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
    public partial class GUIPrivateSchedule : Form
    {
        Form form = null;
        public GUIPrivateSchedule()
        {
            InitializeComponent();
            ShowForm(new GUICalendar());
        }
        private void ChangeColor(Button b)
        {
            bCalendar.BackColor = Color.FromArgb(0, 192, 0);
            bList.BackColor = Color.FromArgb(0, 192, 0);
            b.BackColor = Color.Green;
        }
        private void ShowForm(Form subform)
        {
            if (form != null) form.Close();
            form = subform;
            subform.TopLevel = false;
            subform.FormBorderStyle = FormBorderStyle.None;
            subform.Dock = DockStyle.Fill;
            panel_Content.Controls.Add(subform);
            panel_Content.Tag = subform;
            subform.Show();
        }
        private void bCalendar_Click(object sender, EventArgs e)
        {
            ChangeColor(bCalendar);
            ShowForm(new GUICalendar());
        }

        private void bList_Click(object sender, EventArgs e)
        {
            ChangeColor(bList);
            ShowForm(new GUIDetailSchedule());
        }
    }
}
