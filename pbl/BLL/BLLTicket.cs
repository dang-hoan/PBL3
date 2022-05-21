using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.DTO;

namespace pbl.BLL
{
    internal class BLLTicket
    {
        private static BLLTicket _instance;
        public static BLLTicket instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BLLTicket();
                }
                return _instance;
            }

            private set { }
        }
        private BLLTicket()
        {
        }
        PBL3 db = new PBL3();
        
        public List<TICKET_View> getticketbylist(TICKET_View s, bool book)
        {
            bool Dep = false, Des = false, booked = book;
            if (s.Departure == "") Dep = true;
            if (s.Destination == "") Des = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where (Dep || sch.Departure.Equals(s.Departure)) && (Des || sch.Destination.Equals(s.Destination))
                               && sch.DepartureTime.ToString("dd/MM/yyyy H:m:s").Contains(s.DepartureTime)
                               && sch.ArrivalTime.ToString("dd/MM/yyyy H:m:s").Contains(s.ArrivalTime)
                         select new TICKET_View
                         {
                             ScheduleID = tra.ScheduleID,
                             TrainID = tra.TrainID,
                             TrainName = tra.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = tic.TicketPrice.ToString(),
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString(),
                         };
            return result.ToList();
        }
        public void delticket(string ticketid )
        {
            TICKET s= db.TICKETs.Find(ticketid);
            db.TICKETs.Remove(s);
            db.SaveChanges();

        }    
        public List<TICKET> GettiketBytiketid(string tiketid)
        {
            List<TICKET> data = new List<TICKET>();
            if (tiketid == "")
            {
                data = db.TICKETs.ToList();
            }
            else
            {
                data = db.TICKETs.Where(p => (p.TicketID == tiketid)).Select(p => p).ToList();
            }
            return data;
        }

        public bool check(string ticketid)
        {
            foreach (TICKET i in db.TICKETs)
            {
                if (i.TicketID == ticketid) return true;
            }
            return false;
        }
        //public void delticket(string ticketid)
        //{
        //    TICKET s = db.TICKETs.Find(ticketid);
        //    db.TICKETs.ToList().Remove(s);
        //    db.SaveChanges();
        //}
        public TICKET Getticketbyticketid(string ticketid)
        {
            return db.TICKETs.Find(ticketid);

        }
    }
}
