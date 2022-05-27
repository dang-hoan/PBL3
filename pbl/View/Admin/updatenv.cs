using pbl.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl.View.Admin
{
    public partial class updatenv : Form
    {
        public updatenv()
        {
            InitializeComponent();
            shownv();
        }
        public void shownv()
        {

            dtgaddnv.DataSource = BLLpeople.instance.getallnv(222);
        }

        private void btok_Click(object sender, EventArgs e)
        {
            PEOPLE s = new PEOPLE()
            {
                Username = txtusername.Text,
                Name = txtname.Text,
                Gender = (male.Checked == true) ? true : false,
                BirthDay = date.Value,
                Phone = phone.Text,
                Address = address.Text,
                Email = gmail.Text,
                IDCard = idcard.Text,
               
            };
            BLLpeople.instance.Executenv(s);
            shownv();
        }

        private void dtgaddnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dtgaddnv.Rows[e.RowIndex];
            if(e.RowIndex >= 0)
            {
                txtname.Text = row.Cells[1].Value.ToString();
                txtusername.Text = row.Cells[0].Value.ToString();
                txtusername.Enabled = false;
                if(row.Cells[2].Value.ToString() == "Nam")
                {
                    male.Checked = true;

                }
                else
                {
                    female.Checked = true;
                }

                gmail.Text = row.Cells[6].Value.ToString();
                phone.Text = row.Cells[7].Value.ToString();
                idcard.Text=row.Cells[5].Value.ToString();
                date.Text=row.Cells[3].Value.ToString();
                address.Text   = row.Cells[4].Value.ToString();
                
            }
        }
    }
}
