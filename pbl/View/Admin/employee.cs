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
            showw("111");
        }
        Form f = null;
        public void showw(string Pos)
        {
            Pos = "111";
            dtgridemploy.DataSource = BLLpeople.instance.getallnv(Pos);
        }
        //tao form moi tren form cu
        private void ShowForm(Form subForm)
        {
            if (f != null) f.Close();
            f = subForm;
            
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(subForm);
            panel1.Tag = subForm;
            subForm.Show();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            AddForm f = new AddForm("");
            f.Show();
            f.d = new AddForm.Mydel(showw);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            dtgridemploy.DataSource = BLLpeople.instance.searchP(txtsearch.Text);
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            if (dtgridemploy.SelectedRows.Count == 1)
            {

                string mssv = dtgridemploy.SelectedRows[0].Cells["Username"].Value.ToString();
                AddForm f = new AddForm(mssv);
                f.Show();
                f.d = new AddForm.Mydel(showw);

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
            showw("111");

        }

        private void btsort_Click(object sender, EventArgs e)
        {
            dtgridemploy.DataSource = BLLpeople.instance.sort();
        }
    }
}
