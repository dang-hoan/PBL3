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
    public partial class GUIBook : Form
    {
        public GUIBook()
        {
            InitializeComponent();
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
        private void bBook_Click(object sender, EventArgs e)
        {

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
