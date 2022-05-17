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
using pbl.DTO;

namespace pbl.View
{
    public partial class addve : Form
    {
        public delegate void Mydel(string tiketid);
        public Mydel d;
        public string tiketid { get; set; }
        public addve(string s)
        {
            InitializeComponent();
            tiketid = s;
            GUI();
        }
        public void GUI()
        {
            if (BLLTicket.instance.check(tiketid))
            {
                PEOPLE p = BLLpeople.instance.GetuserByusername(tiketid);
                txtDep.Text = p.Username.ToString();
               
            }
        }
       
    }
}
