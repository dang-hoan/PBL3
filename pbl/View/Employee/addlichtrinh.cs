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
    public partial class addlichtrinh : Form
    {
        public delegate void Mydel(string username);
        public Mydel d;
        public addlichtrinh()
        {
            InitializeComponent();
        }
    }
}
