using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;
using pbl.DTO;


namespace pbl
{
   

    public partial class employee : Form
    {
        public employee()
        {
            
            InitializeComponent();
            showw(222);
        }
        Form f = null;
        public void showw(int Pos)
        {
            Pos = 222;
            dtgridemploy.DataSource = BLLpeople.instance.getallnv(Pos);
        }
        
        
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
           // dtgridemploy.DataSource = BLLpeople.instance.searchP(txtsearch.Text);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (dtgridemploy.SelectedRows.Count == 1)
            {

                string mssv = dtgridemploy.SelectedRows[0].Cells["Username"].Value.ToString();
                //AddForm f = new AddForm(mssv);
                f.Show();
              // f.d = new AddForm.Mydel(showw);

            }
          
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (dtgridemploy.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgridemploy.SelectedRows)
                {

                    BLLpeople.instance.delperson(row.Cells["Username"].Value.ToString());
                }
            }
            showw(111);

        }

        private void btsort_Click(object sender, EventArgs e)
        {
            dtgridemploy.DataSource = BLLpeople.instance.sort();
        }

        private void dtgridemploy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow d = dtgridemploy.Rows[e.RowIndex];

            string Name = d.Cells["Name"].Value.ToString();
            string Gender = d.Cells["Gender"].Value.ToString();
            string Address = d.Cells["Address"].Value.ToString();
            string Email = d.Cells["Email"].Value.ToString();
            string Phone = d.Cells["Phone"].Value.ToString();
            string IDCard = d.Cells["IDCard"].Value.ToString();
            string Possition = d.Cells["Position"].Value.ToString();
            MessageBox.Show("HỌ VÀ TÊN :  " + Name+"\n"
                           +"ĐỊA CHỈ :    " + Address+ "\n"
                           +"EMAIL :      " + Email + "\n"
                           +"SĐT :        " + Phone+"\n"
                           +"IDCARD :     " + IDCard +"\n"
                           +"POSITION :   " + Possition +"\n",
                           "Thông tin nhân viên "

                           );
        }
    }
}
