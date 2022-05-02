using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.DTO
{
    public class TICKET
    {
        public string TicketID { get; set; }
        public string TrainID { get; set; }
        public string SeatNo { get; set; }
        public string TicketPrice { get; set; }
        public bool Booked { get; set; }
        public string CustomerUN { get; set; }
    }
}
