using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    internal class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUILogin());
            //Application.Run(new pbl.View.Passenger.Form1(new DTO.SCHEDULE_BLL
            //{
            //    Departure = "",
            //    Destination = "",
            //    FromDepartureTime = DateTime.Now,
            //    ToDepartureTime = DateTime.Now,
            //    FromArrivalTime = DateTime.Now,
            //    ToArrivalTime = DateTime.Now,
            //}));
        }
    }
}
