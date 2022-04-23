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
    
    public partial class AddForm : Form
    {
        ManageFunction man = new ManageFunction();
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            man.Addnv(username.Text, txtname.Text, male.Checked || !female.Checked, date.Value, address.Text, idcard.Text, gmail.Text, phone.Text, positionid.Text);
            this.Close();
            
        }

       
    }
}
