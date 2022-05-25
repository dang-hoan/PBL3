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
            gui();

        }
        PBL3 db = new PBL3();
        
        public void gui()
        {
            List<string> listDep = new List<string>();
            List<string> listDes = new List<string>();
            BLLTRAIN.Instance.GetStation(ref listDep, ref listDes);
            foreach (string s in listDep.Distinct())
            {
                cbbDep.Items.Add(s);
            }
            foreach (string s in listDes.Distinct())
            {
                cbbDes.Items.Add(s);
            }
            //for (int i = 0; i <= 23; i++)
            //{
            //    cbbHourDep.Items.Add(i);
            //}
            //for (int i = 0; i <= 59; i++)
            //{
            //    cbbMinuteDep.Items.Add(i);
            //}

            cbbook.Items.Add("đã đặt ");
            cbbook.Items.Add("còn trống");
              cbbook.Items.Add("full ");
        }
        public void show(string ticketid)
        {
            dataGridView1.DataSource = BLLTicket.instance.Getticketbyticketid(ticketid);
        }
        private void butsearch_Click(object sender, EventArgs e)
        {
            bool booked;
            string book = cbbook.Text;
            if (book == "đã đặt ")
                booked = true;
            else
            {
                booked = false;
            }
           
           SCHEDULE_View schedule = new SCHEDULE_View()

            {
                Departure = cbbDep.Text,
                Destination = cbbDes.Text,
             //   DepartureTime = DepTime,
     
            };

            dataGridView1.DataSource = BLLTicket.instance.getticketbylist(schedule,booked);
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            addve f = new addve("");
            f.Show();
            f.d = new addve.Mydel(show);
        }
        private void butdat_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    list.Add(dr.Cells["ScheduleID"].Value.ToString());
                }
                GUIBook book = new GUIBook(list);
                book.Show();
            }
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void butxoave_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count >0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    BLLTicket.instance.delticket(row.Cells["ticketid"].Value.ToString());
                }
                show("");
            }    
        }

        //private void cbbHourDep_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (string.Compare(cbbHourDep.Text,"24")> 0)
        //    {
        //        cbbHourDep.Text = "23";
        //    }    
        //}

        //private void cbbMinuteDep_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (string.Compare(cbbMinuteDep.Text, "60") > 0)
        //    {
        //        cbbHourDep.Text = "59";
        //    }
        //}

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butmuave_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    if (dr.Cells["Booked"].ToString() == "chưa đặt")
                    {
                        list.Add(dr.Cells["ScheduleID"].Value.ToString());
                        GUIBook book = new GUIBook(list);
                        book.Show();
                    }
                    else { MessageBox.Show("ve đã được đặt"); }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetAllTICKETView();
        }



        //private void butxoave_Click(object sender, EventArgs e)
        //{
        //    List<string> list = new List<string>();
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
        //        {
        //            list.Add(row.Cells["ScheduleID"].Value.ToString());
        //        }
        //        datve f = new datve(list);
        //        f.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Hãy chọn tối thiểu một lịch trình để đặt vé!");
        //    }
        //}

        //private void butxoave_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count >0)
        //    {
        //        foreach(DataGridViewRow dr in dataGridView1.SelectedRows)
        //        {
        //            BLLTicket.instance.delticket(dr.Cells["ticketid"].Value.ToString());

        //        }
        //        show("");
        //    }    
        //}




        //private void butsearch_Click(object sender, EventArgs e)
        //{
        //    if (dataGridView1.SelectedRows.Count > 0)
        //    {
        //        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
        //        {

        //            BLLTicket.instance.delticket(row.Cells["TicketID"].Value.ToString());
        //        }
        //        show("");
        //    }
        //}


    }
}
