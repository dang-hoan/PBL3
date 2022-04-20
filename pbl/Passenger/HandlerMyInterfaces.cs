using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public class HandlerMyInterfaces
    {
        public static void Controls_MouseMove(object sender, MouseEventArgs e)
        {
            if(((Control)sender).BackColor != System.Drawing.Color.Green)
                ((Control)sender).BackColor = System.Drawing.Color.FromArgb(0, 165, 0);
        }
        public static void Controls_MouseLeave(object sender, EventArgs e)
        {
            if(((Control)sender).BackColor != System.Drawing.Color.Green)
                ((Control)sender).BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
        }
        public static void Button_MouseMove(object sender, MouseEventArgs e)
        {
            if (((Control)sender).BackColor != System.Drawing.Color.Green)
                ((Control)sender).BackColor = System.Drawing.Color.FromArgb(0, 140, 0);
        }
        public static void Button_MouseLeave(object sender, EventArgs e)
        {
            if (((Control)sender).BackColor != System.Drawing.Color.Green)
                ((Control)sender).BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
        }
    }
}
