using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pbl.DTO;

namespace pbl.BLL
{
    public class BLLTicket
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
        public List<CBBItem> GetCBBs()
        {
            List<CBBItem> data = new List<CBBItem>();
            foreach (TRAIN i in db.TRAINs)
            {
                data.Add(new CBBItem
                {
                    Value = i.TrainID.ToString(),
                    Text = i.TrainName

                });

            }
            return data;
        }
        private BLLTicket()
        {
        }
        PBL3 db = new PBL3();
        //public bool check(string ticketid)
        //{
        //    foreach (TICKET i in db.TICKETs)
        //    {
        //        if (i.TicketID == ticketid) return true;
        //    }
        //    return false;
        //}
        public void Execute(TICKET s)
        {
            PBL3 db = new PBL3();

            db.TICKETs.Add(s);
            db.SaveChanges();
        }
        public List<TICKET_View> getticketbylist(SCHEDULE_View schedule, bool book)
        {
        
            bool Dep = false, Des = false, booked = book;
         
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "")Des = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID

                         join TICKET tic in db.TICKETs on tra.TrainID equals tic.TrainID
                         where ((Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination)) && tic.Booked.Equals(booked))
                         //where      sch.DepartureTime.ToString("d/M/yyyy H:m:s").Contains(schedule.DepartureTime)

                         select new TICKET_View
                         {
                             ScheduleID = (int)tra.ScheduleID,
                             TrainID = tra.TrainID.ToString(),
                             TrainName = tra.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = tic.TicketPrice.ToString(),
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString(),
                             Booked = (tic.Booked.Value) ?  "đã đặt": "chưa đặt" 
                         };
            return result.ToList();
        }
        public void delticket(int ticketid )
        {
            TICKET s= db.TICKETs.Find(ticketid);
            db.TICKETs.Remove(s);
            db.SaveChanges();

        }
        //public List<TICKET> GettiketBytiketid(string ticketid)
        //{
        //    List<TICKET> data = new List<TICKET>();
        //    if (ticketid == "")
        //    {
        //        data = db.TICKETs.ToList();
        //    }
        //    else
        //    {
        //        data = db.TICKETs.Where(p => (p.TicketID == ticketid)).Select(p => p).ToList();
        //    }
        //    return data;
        //}

        //public bool check(string ticketid)
        //{
        //    foreach (TICKET i in db.TICKETs)
        //    {
        //        if (i.TicketID == ticketid) return true;
        //    }
        //    return false;
        //}
        //public void delticket(string ticketid)
        //{
        //    TICKET s = db.TICKETs.Find(ticketid);
        //    db.TICKETs.ToList().Remove(s);
        //    db.SaveChanges();
        //}
        public List<TICKET_View> Getticketall(string ticketid)
        {
            List<TICKET_View> data = new List<TICKET_View>();
            foreach (TICKET i in Getticketbyticketid(ticketid))
            {
                var s = from SCHEDULE sch in db.SCHEDULEs.ToList()
                        join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                        join TICKET tic in db.TICKETs on tra.TrainID equals tic.TrainID
                        select new TICKET_View
                        {
                            ScheduleID = (int)tra.ScheduleID,
                            TrainID = tra.TrainID.ToString(),
                            TrainName = tra.TrainName,
                            TicketID = tic.TicketID,
                            SeatNo = tic.SeatNo,
                            TicketPrice = tic.TicketPrice.ToString(),
                            Departure = sch.Departure,
                            Destination = sch.Destination,
                            DepartureTime = sch.DepartureTime.ToString(),
                            ArrivalTime = sch.ArrivalTime.ToString(),
                            Booked = ((bool)tic.Booked.Value) ? "đã đặt" : "chưa đặt",
                        };
        
            };
            return data;
        }
        public List<TICKET> Getticketbyticketid(string ticketid)
        {
            List<TICKET> data = new List<TICKET>();
            if (ticketid == "")
            {
                data= db.TICKETs.ToList();
            }
            else
            {
                data = db.TICKETs.Where(p => p.TicketID == Convert.ToInt32(ticketid) ).Select(p => p).ToList();
            }
            return data;
        }
        public string time (string s)
        {
            if (string.Compare(s, "24") > 0)
            {
                s = "23";
            }
            return s;
        }
    }
}
