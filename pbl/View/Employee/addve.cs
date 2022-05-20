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
            List<string> listDep = new List<string>();
            List<string> listDes = new List<string>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach (string s in listDep.Distinct())
            {
                cbbdep.Items.Add(s);
            }
            foreach (string s in listDes.Distinct())
            {
                cbbdes.Items.Add(s);
            }
        }

        private void butthem_Click(object sender, EventArgs e)
        {

        }
    }
}
