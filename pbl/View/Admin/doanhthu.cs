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

namespace pbl.View.Employee
{
    public partial class doanhthu : Form
    {
        public doanhthu()
        {
            InitializeComponent();
            int[] month = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] year = { 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030 };
            for(int i = 0; i < month.Length; i++)
            {
                cbbmonth.Items.Add(month[i]);
            }
            for (int i = 0; i < year.Length; i++)
            {
                    cbbyear.Items.Add(year[i]);
            }
            

        }

        private void btdoanhthu_Click(object sender, EventArgs e)
        {
            if(cbbmonth.Text == "" || cbbyear.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đủ tháng năm!");
                return;
            }
            dtg.DataSource = BLLTRAIN.Instance.dthu(Convert.ToInt32(cbbmonth.Text),Convert.ToInt32(cbbyear.Text));
        }
        int[] k = { 20,20,25,25,25,25,25,25, 40};
        private void button1_Click(object sender, EventArgs e)
        {
            BLLTRAIN.Instance.Print(dtg, k,"DOANH THU", true);
        }
    }
}
