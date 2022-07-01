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
        Label[] label = new Label[6];
        public note()
        {
            InitializeComponent();
            set();
            init();
        }
       public void set()
       {
                int size = 50;
                int X = 30, Y = 30;
            for (int i = 0; i < 6; i++)
            {
                label[i] = new Label();
                //Tên label
                label[i].Text = (i + 1).ToString();
                label[i].TextAlign = ContentAlignment.MiddleCenter;

                //Kiểu chữ
                label[i].Font = new Font("Arial", 12f, FontStyle.Bold);

                //Kích thước, vị trí

                label[i].AutoSize = true;
                label[i].Location = new Point(X + size , Y + size *(i)  );

                //Trang trí
                label[i].BorderStyle = BorderStyle.FixedSingle;
                label[i].BackColor = Color.Silver;
                this.Controls.Add(label[i]);
            }
            
       }
        public void init()
        {
            int i = 0;
           while (i<6)
           {    
                foreach ( NOTICE no in BLLTicket.instance.Getnotice())
                {
                    label[i].Text = no.Title;
                    label[i + 1].Text = no.Content;
                }
                i += 2;
           }
           
        }
           
    }
}
