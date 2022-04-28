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

namespace pbl
{
    public partial class khachhang : Form
    {
        private DBHelper db = new DBHelper(@"Data Source=DESKTOP-5LQORUF;Initial Catalog=PBL3;Integrated Security=True");
        public khachhang()
        {
            InitializeComponent();
        }
        public void show(int id, string txt)
        {
     
            string q = "";
            if (id == 0)
            {
                q = "select ID,Name,Gender,Birthday,Email,Phone,POSITION.Position from PEOPLE inner join POSITION on PEOPLE.PositionID = POSITION.PositionID where Name like '%" + txt + "%'";
            }
            else
                q = "select ID,Name,Gender,Birthday,Email,Phone,POSITION.Position from PEOPLE inner join POSITION on PEOPLE.PositionID = POSITION.PositionID where PEOPLE.PositionID = " + id + "and Name like '%" + txt + "%'";
       
            dataGridView1.DataSource = db.GetRecord(q,null);
        }
       

        private void btAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void butdel_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = dataGridView1.SelectedRows;

            foreach (DataGridViewRow r in row)
            {
                string MSSV = Convert.ToString(r.Cells["MSSV"].Value);
                string q = "delete from SV where MSSV ='" + MSSV + "'";
                db.ExcuteDB(q,null);

            }
            show(0, "");
        }
       private void buttimkiem_Click(object sender, EventArgs e)
        {
         
            show(0, txtsearch.Text);
        }
    }
}
