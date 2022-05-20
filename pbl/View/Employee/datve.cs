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
    public partial class datve : Form
    {

        public delegate void mydel();
        public mydel d;
        string ticketid { get; set; }


        public datve(string s )
        {
            InitializeComponent();
            ticketid = s;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
