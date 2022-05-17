using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using pbl.BLL;
using pbl.DTO;

namespace pbl.View


{
    public partial class khachhang : Form
    {



        public khachhang()
        {
            InitializeComponent();

            cbbshow.Items.Add(new CBBItem { Value = "", Text = "All" });
            cbbshow.Items.AddRange(BLLpeople.instance.GetCBBs("").ToArray());
        }
        public void show(string username)
        {
<<<<<<< HEAD
     
        dataGridView1.DataSource = BLLpeople.instance.getppbylist(username);
=======
            dataGridView1.DataSource = BLLpeople.instance.GetuserByusername(username);
>>>>>>> 341ff11a28855dbf20a7362c630a6610b37e642a
        }
        private void butdel_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.SelectedRows.Count > 0 )
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                   
                    BLLpeople.instance.delperson(row.Cells["Username"].Value.ToString());
                }
                show("");
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
                addkhachhang f = new addkhachhang(" ");
                f.Show();
                f.d = new addkhachhang.Mydel(show);
           
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string username = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
                addkhachhang f  = new addkhachhang(username);
                f.Show();
                f.d = new addkhachhang.Mydel(show);
               
            }
        }

        private void butshow_Click(object sender, EventArgs e)
        {
            string username = ((CBBItem)cbbshow.SelectedItem).Value;
            show(username);
        }

        private void khachhang_TextChanged(object sender, EventArgs e)
        {
                cbbshow.Items.Clear();
                cbbshow.Items.AddRange(BLLpeople.instance.GetCBBs(cbbshow.Text).ToArray());
        }
    }
}
