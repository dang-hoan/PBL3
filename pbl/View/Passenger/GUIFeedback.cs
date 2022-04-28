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
    public partial class GUIFeedback : Form
    {
        PictureBox[] ListStar = new PictureBox[5];
        Image image1 = (Image)new Bitmap(@"C:\PBL3\picture\star feed.png"), image2 = (Image)new Bitmap(@"C:\PBL3\picture\favourites.png");
        public GUIFeedback()
        {
            InitializeComponent();
            CreateStar();
        }
        private void CreateStar()
        {
            int orginX = labelStar.Location.X + 120, orginY = labelStar.Location.Y - 10, distance = 56;
            for(int i = 0; i < 5; i++)
            {
                ListStar[i] = new PictureBox();
                ListStar[i].Image = image1;
                ListStar[i].Size = new Size(39, 35);
                ListStar[i].Location = new Point(orginX + distance*i, orginY);

                ListStar[i].SizeMode = PictureBoxSizeMode.Zoom;

                ListStar[i].MouseMove += new System.Windows.Forms.MouseEventHandler(pStar_MouseMove);
                
                this.Controls.Add(ListStar[i]);
            }
        }

        private void pStar_MouseMove(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).Image = image2;
        }

        private void bSend_Click(object sender, EventArgs e)
        {

        }

        private void bDeleteAll_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                ListStar[i].Image = image1;
            }
            txtOpinion.Text = "";
        }
    }
}
