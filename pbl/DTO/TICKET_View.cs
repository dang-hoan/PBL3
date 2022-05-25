using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.DTO
{
    public class TICKET_View
    {
        public string ScheduleID { get; set; }
        public string TrainID { get; set; }
        public string TrainName { get; set; }
        public int TicketID { get; set; }
        public string SeatNo { get; set; }
        public string TicketPrice { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public string DepartureTime { get; set; }
        public string ArrivalTime { get; set; }
        public string Booked { get; set; }
        public string OwnUsername { get; set; }
        public string OwnName { get; set; }

    }
}
