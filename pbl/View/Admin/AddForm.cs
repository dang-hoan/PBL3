using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;

namespace pbl
{
    
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BLLTRAIN.Instance.Addnv(username.Text, txtname.Text, male.Checked || !female.Checked, date.Value, address.Text, idcard.Text, gmail.Text, phone.Text, positionid.Text);
            this.Close();
           
        }

       
    }
}
