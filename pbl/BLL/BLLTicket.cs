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
            if (schedule.Destination == "") Des = true;
            var result = from tic in db.TICKETs
                         where ((Dep || tic.TRIP.SCHEDULE.STATION1.StationName.Equals(schedule.Departure)) && (Des || tic.TRIP.SCHEDULE.STATION.StationName.Equals(schedule.Destination)) && tic.Booked.Equals(booked))
                         //where      sch.DepartureTime.ToString("d/M/yyyy H:m:s").Contains(schedule.DepartureTime)

            //var result = from sch in db.SCHEDULEs.ToList()
            //             join tra in db.TRAINs on sch.ScheduleID equals tri.TRAIN.ScheduleID

            //             from tic in tri.TRAIN.TICKETs
            //             where ((Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination)) && tic.Booked.Equals(booked))


                         select new TICKET_View
                         {
                             ScheduleID = tic.TRIP.ScheduleID,
                             TrainID = tic.TRIP.TrainID,
                             TrainName = tic.TRIP.TRAIN.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = (double)tic.TicketPrice,
                             Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                             Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                             DepartureTime = tic.TRIP.SCHEDULE.DepartureTime,
                             ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime,
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
                var s = from tic in db.TICKETs
                        select new TICKET_View
                        {
                            ScheduleID = tic.TRIP.ScheduleID,
                            TrainID = tic.TRIP.TrainID,
                            TrainName = tic.TRIP.TRAIN.TrainName,
                            TicketID = tic.TicketID,
                            SeatNo = tic.SeatNo,
                            TicketPrice = (double)tic.TicketPrice,
                            Departure = tic.TRIP.SCHEDULE.STATION1.StationName,
                            Destination = tic.TRIP.SCHEDULE.STATION.StationName,
                            DepartureTime = tic.TRIP.SCHEDULE.DepartureTime,
                            ArrivalTime = tic.TRIP.SCHEDULE.ArrivalTime,
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
