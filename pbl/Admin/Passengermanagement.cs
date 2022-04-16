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
    public partial class Passengermanagement : Form
    {
        Form form;
        public Passengermanagement(Form form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            this.Close();
            form.Show();
        }
    }
}
