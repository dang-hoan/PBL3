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


        int tk;
        public khachhang()
        {
            InitializeComponent();
            init("");
            cbbshow.Text = "Tất Cả";
            show("");
            cbbshow.Items.Add("Tất cả");
            cbbshow.Items.Add("Tìm kiếm theo tên");
            cbbshow.Items.Add("Tìm kiếm theo căn cước");
            cbbshow.Items.Add("Tìm kiếm theo tên đăng nhập");
        }
        public void show(string username)
        {
        dataGridView1.DataSource = BLLpeople.instance.getppbylist(username,1);

        }
        public void showid(string username)
        {
            dataGridView1.DataSource = BLLpeople.instance.getppbylist(username, 2);

        }
        public void showname(string username)
        {
            dataGridView1.DataSource = BLLpeople.instance.getppbylist(username, 3);

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
                addkhachhang f = new addkhachhang("");
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
        public void init(string s)
        {
            
            txtsearch.Enabled = false;

            if (s == "ten")
            { txtsearch.Text = "Tìm kiếm theo tên";
                tk = 1;
            }
            if (s == "user")
            { txtsearch.Text = "Tìm kiếm theo tên đăng nhập";
                tk = 3;
            }
            if (s == "id")
            { txtsearch.Text = "Tìm kiếm theo căn cước";
                tk = 2; }

        }
        private void butshow_Click(object sender, EventArgs e)
        {
            if (cbbshow.Text == "Tất cả")
                show("");
            else
            {
                if (cbbshow.Text == "Tìm kiếm theo tên đăng nhập")
                {
                    string name = txtsearch.Text;
                    show(name);
                }
                else
                    if (cbbshow.Text == "Tìm kiếm theo căn cước")
                {
                    string name = txtsearch.Text;
                    showid(name);
                }
                else
                    if (cbbshow.Text == "Tìm kiếm theo tên")
                {
                    string name = txtsearch.Text;
                    showname(name);
                }

            }
        }

        private void khachhang_TextChanged(object sender, EventArgs e)
        {
               // cbbshow.Items.Clear();
                cbbshow.Items.AddRange(BLLpeople.instance.GetCBBs(cbbshow.Text).ToArray());
        }

        private void cbbshow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbbshow_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbbshow.Text == "Tất cả")
            {
                txtsearch.Enabled = false;
            }    
            if (cbbshow.Text == "Tìm kiếm theo tên")
            {
                init("ten");
                txtsearch.Enabled = true;
            }
            else if (cbbshow.Text == "Tìm kiếm theo tên đăng nhập")
            {
                init("user");
                txtsearch.Enabled = true;
            }
            else if (cbbshow.Text == "Tìm kiếm theo căn cước")
            {
                init("id");
                txtsearch.Enabled = true;
            }
            
               
        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            txtsearch.Text = "";
        }
    }
}
