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

namespace pbl.Admin
{
    public partial class addschedule : Form
    {
        public delegate void Mydel(string usern);
        public Mydel d;
        public string usern { get; set; }
        public addschedule()
        {
            InitializeComponent();
        }

        private void bTOK_Click(object sender, EventArgs e)
        {

            SCHEDULE s = new SCHEDULE()
            {
                ScheduleID =txtid.Text,
                Departure = cbbgadi.Text,
                Destination = cbbgaden.Text,
                DepartureTime = datengaydi.Value,
                
            };

           // BLLTRAIN.Instance.Execute(s);
            d("");
            this.Close();
        }
    }
}
