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
    public partial class qlve : Form
    {
        public qlve()
        {
            InitializeComponent();
        }
        PBL3 db = new PBL3();
        public void show(string ticketid)
        {
           // dataGridView1.DataSource = BLLTicket.instance.getticketbylist(ticketid);
        }
       
      
        private void butsearch_Click(object sender, EventArgs e)
        {
            //string DepTime, DesTime,book;
           
            //DesTime = dateDes.Value.ToString("d/M/yyyy");
            //DepTime = dateDep.Value.ToString("d/M/yyyy");
            //if (cbbHourDep.Text != "" && cbbMinuteDep.Text != "")
            //{
            //    DepTime += " " + cbbHourDep.Text + ":" + cbbMinuteDep.Text;
            //}
            //if (cbbHourDes.Text != "" && cbbMinuteDes.Text != "")
            //{
            //    DesTime += " " + cbbHourDes.Text + ":" + cbbMinuteDes.Text;
            //}
            //SCHEDULE_View s = new SCHEDULE_View()
            //{
            //    Departure = cbbgadi.Text,
            //    Destination = cbbgaden.Text,
            //    DepartureTime = DepTime,
            //    ArrivalTime = DesTime,
              
            // };
            //dataGridView1.DataSource = BLLTRAIN.Instance.GetSchedule(s);
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            addve f = new addve(" ");
            f.Show();
            f.d = new addve.Mydel(show);
        }

        private void butsua_Click(object sender, EventArgs e)
        {
           if(dataGridView1.SelectedRows.Count > 0)
            {
                string ticketid = dataGridView1.SelectedRows[0].Cells["TicketID"].Value.ToString();
                addve f = new addve(ticketid);
                f.Show();
                f.d = new addve.Mydel(show);
            }    
        }
        private void butdat_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                datve f  = new datve();
                f.Show();
            }    
        }

<<<<<<< HEAD
        private void butxoave_Click(object sender, EventArgs e)
=======
        

        private void butsearch_Click(object sender, EventArgs e)
>>>>>>> 341ff11a28855dbf20a7362c630a6610b37e642a
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {

                    BLLTicket.instance.delticket(row.Cells["TicketID"].Value.ToString());
                }
                show("");
            }
        }

        
    }
}
