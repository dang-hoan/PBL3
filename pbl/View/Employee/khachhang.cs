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

namespace pbl
{
    public partial class khachhang : Form
    {
        //private DBHelper db = new DBHelper(@"Data Source=DESKTOP-5LQORUF;Initial Catalog=PBL3;Integrated Security=True");
        public khachhang()
        {
            InitializeComponent();
            cbbshow.Items.Add(new CBBItem { Value = 0, Text = "All" });
            cbbshow.Items.AddRange(BLLTRAIN.Instance.GetCBBs().ToArray());
        }
        PBL3 db = new PBL3();
        public void show(string username)
        {
            dataGridView1.DataSource = BLLTRAIN.Instance.GetSVByIDLop(username);
        }
        private void butdel_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.SelectedRows.Count > 0 )
            {
                foreach(DataGridViewRow row in dataGridView1.SelectedRows)
                {
                   
                    BLLTRAIN.Instance.delperson(row.Cells["Username"].Value.ToString());
                }
                show("");
            }
        }
    }
}
