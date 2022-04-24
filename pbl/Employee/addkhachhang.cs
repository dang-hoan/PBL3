using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public delegate void mydel(int id);
    public mydel d { get; set; }
    private DBHelper db = new DBHelper(@"Data Source=DESKTOP-5LQORUF;Initial Catalog=PBL3;Integrated Security=True");
    public string mssv { get; set; }
    public partial class addkhachhang : Form
    {
        public addkhachhang()
        {
            InitializeComponent();
        }


    }
}