using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public class HandlerMyInterfaces
    {
        public Color First { get; set; }
        public Color Move { get; set; }
        public Color Click { get; set; }
        public HandlerMyInterfaces(Color First, Color Move, Color Click)
        {
            this.First = First;
            this.Move = Move;
            this.Click = Click;
        }
        public void Controls_MouseMove(object sender, MouseEventArgs e)
        {
            if(((Control)sender).BackColor != Click)
                ((Control)sender).BackColor = Move;
        }
        public void Controls_MouseLeave(object sender, EventArgs e)
        {
            if(((Control)sender).BackColor != Click)
                ((Control)sender).BackColor = First;
        }
        public void Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != Click)
                ((Control)sender).BackColor = Move;
        }
        public void Button_MouseLeave(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != Click)
                ((Control)sender).BackColor = First;
        }
    }
}
