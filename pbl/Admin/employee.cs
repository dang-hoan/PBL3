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

namespace pbl
{
    public partial class employee : Form
    {
       
        ManageFunction man = new ManageFunction();
        public employee()
        {
            InitializeComponent();
            dtgridemploy.DataSource = man.GetAllNV();
        }
        Form f = null;
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
            AddForm add =   new AddForm();
            add.Show();
            man.GetAllNV();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttimkiem_Click(object sender, EventArgs e)
        {
            string s = @"Data Source=DESKTOP-59M8QSM\SQLEXPRESS;Initial Catalog=pbl33;Integrated Security=True";
            //DBHelper db = new DBHelper(s);
            string query = "select * from PEOPLE where Name = '" + txttimkiem.Text + "'";
            //dataGridView1.DataSource = db.GetRecordSV(query);
            SqlConnection cnn = new SqlConnection(s);
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            dtgridemploy.DataSource = dt;
        }
       /* public void GetAllNV()
        {
            cnn.Open();
            string query = "select * from PEOPLE  where PositionID ='"+222+"'";
               

            
           
            SqlCommand com = new SqlCommand(query, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            
            dtgridemploy.DataSource = dt; //đổ dữ liệu vào datagridview
        }*/
    }
}
