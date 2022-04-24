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
    public partial class GUITicket : Form
    {
        ManageFunction man = new ManageFunction();
        public GUITicket()
        {
            InitializeComponent();
            dataGridView1.DataSource = man.GetAllTicket();
        }

        private void bBook_Click(object sender, EventArgs e)
        {
            GUIBook form = new GUIBook();
            form.Show();
        }

        private void pOption_Click(object sender, EventArgs e)
        {
            GUIOption option = new GUIOption();
            option.Show();
        }

        private void labelSchedule_Click(object sender, EventArgs e)
        {
            GUIOption option = new GUIOption();
            option.Show();
        }

        private void bShow_Click(object sender, EventArgs e)
        {

        }
    }
}
