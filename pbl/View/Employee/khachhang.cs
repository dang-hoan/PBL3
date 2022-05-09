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
            cbbshow.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbshow.Items.AddRange(BLLpeople.instance.GetCBBs().ToArray());
        }
        PBL3 db = new PBL3();
        public void show(string username)
        {
            dataGridView1.DataSource = BLLpeople.instance.GetuserByusername(username);
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
            if (dataGridView1.SelectedRows.Count == 1)
            {

                string mssv = dataGridView1.SelectedRows[0].Cells["Username"].Value.ToString();
                 addkhachhang f  = new addkhachhang(mssv);
                f.Show();
                f.d = new addkhachhang.Mydel(show);

            }
        }
    }
}
