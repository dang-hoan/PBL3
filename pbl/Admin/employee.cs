using System;
using System.Collections.Generic;
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
        public employee()
        {
            InitializeComponent();
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
        }
    }
}
