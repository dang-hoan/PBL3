using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.DTO
{
    public class doanhthu_view
    {
        public int TrainID { get; set; }
        public string TrainName{ get; set; }
        public string Depature { get; set; }
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int TotalTickets { get; set; }
        public double Totalmoney { get; set; }
       
    }
}
