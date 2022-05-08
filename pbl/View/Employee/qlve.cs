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

namespace pbl.Employee
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
            dataGridView1.DataSource = BLLTicket.instance.Getticketbyticketid(ticketid);
        }
        private void butdat_Click(object sender, EventArgs e)
        {

        }

        

        private void butsearch_Click(object sender, EventArgs e)
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
