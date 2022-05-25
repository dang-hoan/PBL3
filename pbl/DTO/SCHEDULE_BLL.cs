using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.DTO
{
    public class SCHEDULE_BLL
    {
        public int ScheduleID { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public DateTime FromDepartureTime { get; set; }
        public DateTime ToDepartureTime { get; set; }
        public DateTime FromArrivalTime { get; set; }
        public DateTime ToArrivalTime { get; set; }
    }
}
