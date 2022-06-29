using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;

namespace pbl.View.Admin
{
    public partial class Notice : Form
    {
        public Notice()
        {
            InitializeComponent();
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text == "" || txtContent.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ tiêu đề và nội dung của thông báo!");
                return;
            }
            NOTICE notice = new NOTICE
            {
                Title = txtTitle.Text,
                Content = txtContent.Text
            };
            BLLTRAIN.Instance.AddNotice(notice);
            MessageBox.Show("Đã thêm thông báo vào hệ thống!");
        }

        private void bNew_Click(object sender, EventArgs e)
        {
            this.txtTitle.Text = "";
            this.txtContent.Text = "";
        }

        private void Notice_Load(object sender, EventArgs e)
        {

        }
    }
}
