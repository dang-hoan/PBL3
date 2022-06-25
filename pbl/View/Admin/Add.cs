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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void bConfirm_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "" || txtusername.Text == "" || txtpass.Text == "" || idcard.Text == "" || gmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin bắt buộc !");
                return;
            }
            else if (usernamedk.Text != "")
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại");
                return;
            }
            else
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
                LOGIN l = new LOGIN()
                {
                    State = true,
                    PassWord = txtpass.Text,
                    Username = txtusername.Text,
                };
                BLLpeople.instance.Executenv(s);
                BLLpeople.instance.Execute2(l);
                MessageBox.Show("Đã thêm thành công nhân viên mới!");
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
