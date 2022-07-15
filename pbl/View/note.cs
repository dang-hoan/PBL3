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

namespace pbl
{
    public partial class note : Form
    {
        Label[] label = new Label[30];
        public note()
        {
            InitializeComponent();
            set();
        }
       public void set()
       {
            int s = 0;
            foreach(NOTICE no in BLLTicket.instance.Getnotice())
            {
                s ++;
            }
            init(s);
            
       }
        public void init(int s)
        {
            int i = 0;
                foreach (NOTICE no in BLLTicket.instance.Getnotice())
                {
                   if (i <  s-1)
                   {
                    label1.Text = no.Title;
                    txt1.Text = no.Content;
                    i++;
                   }
                   else
                   { 
                    label3.Text = no.Title;
                    txt3.Text = no.Content;
                   }

                }
              
        }
        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show((txt1).Text);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show((txt3).Text);
        }
    }
}
