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
    public partial class GUIForget : Form
    {
        Form login;
        public GUIForget(Form login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void bAgree_Click(object sender, EventArgs e)
        {

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            login.Show();
        }
    }
}
