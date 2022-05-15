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
        //public List<TICKET_View> getticketbylist(TICKET_View s)
        //{
        //    List<TICKET_View> data = new List<TICKET_View>();
        //    foreach (TICKET i in Getticketbyticketid(ticketid))
        //    {
        //         data.Add(new TICKET_View
        //         {
        //             TicketID = i.TicketID,
        //             TrainID = i.TrainID,
        //             SeatNo = i.SeatNo,
        //             TicketPrice = i.TicketPrice.ToString(),
        //             Booked = i.Booked.Value,


        //         });
        //    }
        //    return data;
        //}
        //public List<TICKET> GettiketBytiketid(string tiketid)
        //{
        //    List<TICKET> data = new List<TICKET>();
        //    if (tiketid == "")
        //    {
        //        data = db.TICKETs.ToList();
        //    }
        //    else
        //    {
        //        data = db.TICKETs.Where(p => (p.TicketID == tiketid)).Select(p => p).ToList();
        //    }
        //    return data;
        //}

        public bool check(string ticketid)
        {
            foreach (TICKET i in db.TICKETs)
            {
                if (i.TicketID == ticketid) return true;
            }
            return false;
        }
        public void delticket(string ticketid)
        {
            TICKET s = db.TICKETs.Find(ticketid);
            db.TICKETs.Remove(s);
            db.SaveChanges();
        }
        public TICKET Getticketbyticketid(string ticketid)
        {
            return db.TICKETs.Find(ticketid);

        }
    }
}
