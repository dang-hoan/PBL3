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

namespace pbl.View
{
    public partial class MessageNotice : Form
    {
        private TICKET t;
        public delegate void MyDel();
        public MyDel d;
        public MessageNotice(string Notice, string Title, string b1, string b2, TICKET t)
        {
            InitializeComponent();
            labNote.Text = Notice;
            this.Text = Title;
            button1.Text = b1;
            button2.Text = b2;
            this.t = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn huỷ vé đã chọn không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                BLLTRAIN.Instance.addticket(t, false);
                MessageBox.Show("Đã huỷ vé bạn chọn!");
                d();
                this.Close();
            }
        }
    }
}
