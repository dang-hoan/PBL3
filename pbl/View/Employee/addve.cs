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
using pbl.DTO;

namespace pbl.View
{
    public partial class addve : Form
    {
        public delegate void Mydel(string trainid);
        public Mydel d;
        public string trainid { get; set; }
        string kiemtra = "";
        public addve(string s)
        {
            InitializeComponent();
            trainid = s;
            kiemtra=s;
            GUI();
            intit();

        }
        public void thamchieu(string trainid)
        {
            txttrainid.Text = trainid;
        }
        public void intit()
        {
       
            foreach (Train_View i in BLLTRAIN.Instance.GetTrain2(trainid))
            {
                txtschedule.Text= i.ScheduleID;
                txtschedule.Enabled = false;
                txttrainid.Text = i.TrainID;
                txttrainid.Enabled = false;
                txtname.Text = i.TrainName;
                txtname.Enabled = false;
                txtsotau.Text = i.NumberOfCarriages;
                int num = Convert.ToInt32(i.NumberOfCarriages);
                txtma.Text=num.ToString();
                txtsotau.Enabled = false;
            }
        }
        public void GUI()
        { 
            for (int i = 0; i <= 25; i++)
            {
                cbbseat.Items.Add(i.ToString());
            }

        }

        private void butthem_Click(object sender, EventArgs e)
        { 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addve_Load(object sender, EventArgs e)
        {

        }

        private void pChat_Click(object sender, EventArgs e)
        {if (kiemtra == "")
            {
                trainve s = new trainve();
                s.Show();
                this.Close();
            }
            else MessageBox.Show("ban da chon 1 lich trinh trc do");
        }

        private void txtgiave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
