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
    public partial class khachhang : Form
    {
        private DBHelper db = new DBHelper(@"Data Source=DESKTOP-5LQORUF;Initial Catalog=PBL3;Integrated Security=True");
        public khachhang()
        {
            InitializeComponent();
        }
        public void show(int id)
        {
            string query = "";
            if (id == 0)
            {

                query = "select * from SV";
            }
            else
            {

                query = "select * from SV where ID = " + id;
            }
            dataGridView1.DataSource = db.GetRecord(query,cnn);
        }
       

        private void btAdd_Click(object sender, EventArgs e)
        {
            addkhachhang f = new addkhachhang();
            f.Show();
        }

        private void butdel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                string query = $"delete from SV where ID = {id}";
                db.ExcuteDB(query,"");
                
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                string id = dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString();
                addkhachhang f = new addkhachhang(id);
                f.d = new addkhachhang.mydel(show);
                f.Show();
            }
        }
    }
}
