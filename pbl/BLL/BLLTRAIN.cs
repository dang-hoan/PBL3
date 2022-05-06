﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pbl.BLL;
using pbl.DTO;

//3 loop able: list<SCHEDULE>, list<PEOPLE>, list<POSITION>
namespace pbl.BLL
{
    public class BLLTRAIN
    {
        private static BLLTRAIN _Instance;
        public static BLLTRAIN Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLLTRAIN();
                }
                return _Instance;
            }
            private set { }
        }
        private BLLTRAIN()
        {

        }
        public string CheckAccount(string Username, string Password)
        {
            PBL3 db = new PBL3();
            var ketqua = from u in db.LOGINs
                         where u.Username == Username && u.PassWord == Password
                         select u.Username;
            foreach(LOGIN log in db.LOGINs)
            {
                if(log.Username.Equals(Username) && log.PassWord.Equals(Password))
                {
                    return from pos in db.POSITIONs
                           join peo in db.PEOPLE
                           where pos.PositionID.Equals(peo.PositionID)
                           select pos.Position;
                }
            }
            return "Không tồn tại";
        }
        public List<CBBItem> GetCBBs()
        {
            PBL3 db = new PBL3();
            List<CBBItem> data = new List<CBBItem>();
            foreach (PEOPLE i in db.PEOPLE)
            {
                data.Add(new CBBItem
                {
                    Value = int.Parse(i.Username.ToString()),
                    Text = i.Name

                });

            }
            return data;
        }
        public void delperson(string username)
        {
            PBL3 db = new PBL3();
            PEOPLE s = db.PEOPLE.Find(username);
            db.PEOPLE.Remove(s);
            db.SaveChanges();
        }
        public List<PEOPLE> GetSVByIDLop(string username)
        {
            PBL3 db = new PBL3();
            List<PEOPLE> data = new List<PEOPLE>();
            if (username == "")
            {
                data = db.PEOPLE.ToList();
            }
            else
            {
                data = db.PEOPLE.Where(p => p.Username == username).Select(p => p).ToList();
            }
            return data;

        }
        public void Add()
        {
            PBL3 db = new PBL3();

        }
        public int UpdatePEOPLE(PEOPLE p)
        {
            PBL3 db = new PBL3();
            return DALTRAIN.Instance.UpdatePEOPLE(p);
        }
        public int UpdatePass(string userName, string oldPassword, string newPassword)
        {
            PBL3 db = new PBL3();
            return DALTRAIN.Instance.UpdatePass(userName, oldPassword, newPassword);
        }
        public void Delete()
        {
            PBL3 db = new PBL3();

        }
        public void Sort()
        {
            PBL3 db = new PBL3();

        }

        public List<TICKET_View> GetAllTICKETView()
        {
            PBL3 db = new PBL3();
            List<TICKET_View> result = new List<TICKET_View>();
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                {
                    if (t.ScheduleID.Equals(s.ScheduleID))
                    {
                        foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                        {
                            if (ti.TrainID.Equals(t.TrainID))
                            {
                                if (ti.Booked == false)
                                {
                                    result.Add(new TICKET_View
                                    {
                                        ScheduleID = t.ScheduleID,
                                        TrainID = t.TrainID,
                                        TrainName = t.TrainName,
                                        TicketID = ti.TicketID,
                                        SeatNo = ti.SeatNo,
                                        TicketPrice = ti.TicketPrice,
                                        Departure = s.Departure,
                                        Destination = s.Destination,
                                        DepartureTime = s.DepartureTime,
                                        ArrivalTime = s.ArrivalTime,
                                        Booked = ti.Booked,
                                        OwnUsername = "",
                                        OwnName = ""
                                    });
                                    continue;
                                }
                                foreach (PEOPLE p in DALTRAIN.Instance.GetAllPEOPLE())
                                {
                                    if (p.Username.Equals(ti.CustomerUN))
                                    {
                                        result.Add(new TICKET_View
                                        {
                                            ScheduleID = t.ScheduleID,
                                            TrainID = t.TrainID,
                                            TrainName = t.TrainName,
                                            TicketID = ti.TicketID,
                                            SeatNo = ti.SeatNo,
                                            TicketPrice = ti.TicketPrice,
                                            Departure = s.Departure,
                                            Destination = s.Destination,
                                            DepartureTime = s.DepartureTime,
                                            ArrivalTime = s.ArrivalTime,
                                            Booked = ti.Booked,
                                            OwnUsername = p.Username,
                                            OwnName = p.Name
                                        });
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        public List<PEOPLE_View> GetAllPEOPLEView()
        {
            PBL3 db = new PBL3();
            List<PEOPLE_View> result = new List<PEOPLE_View>();
            foreach (PEOPLE p in DALTRAIN.Instance.GetAllPEOPLE())
            {
                foreach (POSITION po in DALTRAIN.Instance.GetAllPOSITION())
                {
                    if (po.PositionID.Equals(p.PositionID))
                    {
                        result.Add(new PEOPLE_View
                        {
                            Username = p.Username,
                            Name = p.Name,
                            Gender = p.Gender,
                            BirthDay = p.BirthDay,
                            Address = p.Address,
                            IDCard = p.IDCard,
                            Email = p.Email,
                            Phone = p.Phone,
                            Position = po.Position
                        });
                        break;
                    }
                }
            }
            return result;
        }
        public List<PEOPLE_View> GetPEOPLEViewByUsername(string Username)
        {
            PBL3 db = new PBL3();
            List<PEOPLE_View> data = new List<PEOPLE_View>();
            if (Username == "")
            {
                data = BLLTRAIN.Instance.GetAllPEOPLEView();
            }
            else
            {
                foreach (PEOPLE_View i in BLLTRAIN.Instance.GetAllPEOPLEView())
                {
                    if (i.Username.Equals(Username))
                    {
                        data.Add(i);
                        break;
                    }
                }
            }
            return data;
        }

        //Passenger
        public string GetName(string Username)
        {
            PBL3 db = new PBL3();
            foreach (PEOPLE p in DALTRAIN.Instance.GetAllPEOPLE())
            {
                if (p.Username.Equals(Username)) return p.Name;
            }
            return "";
        }
        public List<TICKET_User_View> GetTicket(string userName)
        {
            PBL3 db = new PBL3();
            List<TICKET_User_View> result = new List<TICKET_User_View>();
            foreach (TICKET_View t in BLLTRAIN.Instance.GetAllTICKETView())
            {
                if (t.OwnUsername.Equals(userName)) result.Add(new TICKET_User_View
                {
                    ScheduleID = t.ScheduleID,
                    TrainID = t.TrainID,
                    TrainName = t.TrainName,
                    TicketID = t.TicketID,
                    SeatNo = t.SeatNo,
                    TicketPrice = t.TicketPrice,
                    Departure = t.Departure,
                    Destination = t.Destination,
                    DepartureTime = t.DepartureTime,
                    ArrivalTime = t.ArrivalTime
                });
            }
            return result;
        }
        public List<TICKET_User_View> GetTicket(SCHEDULE schedule, string userName, string TrainName)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false, Train = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            if (TrainName == "") Train = true;
            List<TICKET_User_View> result = new List<TICKET_User_View>();
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                if ((Dep || s.Departure.Equals(schedule.Departure)) && (Des || s.Destination.Equals(schedule.Destination))
                    && s.DepartureTime.Contains(schedule.DepartureTime) && s.ArrivalTime.Contains(schedule.ArrivalTime))
                {
                    foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                    {
                        if (t.ScheduleID.Equals(s.ScheduleID) && (Train || t.TrainName.Equals(TrainName)))
                        {
                            foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                            {
                                if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName)) result.Add(new TICKET_User_View
                                {
                                    ScheduleID = t.ScheduleID,
                                    TrainID = t.TrainID,
                                    TrainName = t.TrainName,
                                    TicketID = ti.TicketID,
                                    SeatNo = ti.SeatNo,
                                    TicketPrice = ti.TicketPrice,
                                    Departure = s.Departure,
                                    Destination = s.Destination,
                                    DepartureTime = s.DepartureTime,
                                    ArrivalTime = s.ArrivalTime
                                });
                            }
                        }
                    }

                }
            }
            return result;
        }
        public List<TICKET_View> GetTicket(List<string> list)
        {
            PBL3 db = new PBL3();
            List<TICKET_View> result = new List<TICKET_View>();
            foreach (string id in list)
            {
                foreach (TICKET_View t in BLLTRAIN.Instance.GetAllTICKETView())
                {
                    if (t.ScheduleID.Equals(id)) result.Add(t);
                }
            }
            return result;
        }
        private char[] carriage = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public List<TICKET_View> GetTicket(List<string> list, string TrainName, int carriage, ref int booked, ref int unbooked)
        {
            PBL3 db = new PBL3();
            bool Train = false;
            if (TrainName == "") Train = true;
            List<TICKET_View> result = new List<TICKET_View>();
            int sum = 0;
            foreach (string id in list)
            {
                foreach (TICKET_View t in BLLTRAIN.Instance.GetAllTICKETView())
                {
                    if (t.ScheduleID.Equals(id) && (Train || t.TrainName.Equals(TrainName)))//2 tàu trùng tên
                    {
                        sum++;
                        if (t.Booked) booked++;
                        if (t.SeatNo.Contains(this.carriage[carriage - 1])) result.Add(t);
                    }
                }
            }
            unbooked = sum - booked;
            return result;
        }
        public List<string> GetTrain(string userName)
        {
            PBL3 db = new PBL3();
            List<string> result = new List<string>();
            foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
            {
                foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                {
                    if (ti.TrainID.Equals(t.TrainID))
                    {
                        if (ti.CustomerUN.Equals(userName)) result.Add(t.TrainName);
                        else break;
                    }
                }
            }
            return result;
        }
        public List<string> GetTrain(SCHEDULE schedule, string userName)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            List<string> result = new List<string>();
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                if ((Dep || s.Departure.Equals(schedule.Departure)) && (Des || s.Destination.Equals(schedule.Destination))
                    && s.DepartureTime.Contains(schedule.DepartureTime) && s.ArrivalTime.Contains(schedule.ArrivalTime))
                {
                    foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                    {
                        if (t.ScheduleID.Equals(s.ScheduleID))
                        {
                            foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                            {
                                if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName)) result.Add(t.TrainName);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public List<string> GetTrain(List<string> list)
        {
            PBL3 db = new PBL3();
            List<string> result = new List<string>();
            foreach (string id in list)
            {
                foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                {
                    if (t.ScheduleID.Equals(id))
                    {
                        result.Add(t.TrainName);
                    }
                }
            }
            return result;
        }
        public void SetTicket(string TicketID, string userName, bool booked)
        {
            PBL3 db = new PBL3();
            DALTRAIN.Instance.SetTicket(TicketID, userName, booked);
        }
        public int GetNumberOfCarriages(string TrainName)
        {
            PBL3 db = new PBL3();
            if (TrainName == "")
                return 25;
            foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
            {
                if (t.TrainName.Equals(TrainName))
                    return t.NumberOfCarriages;
            }
            return 25;
        }
        public int GetNumberBooked(List<string> list, string TrainName)
        {
            PBL3 db = new PBL3();
            int result = 0;
            bool Train = false;
            if (TrainName == "") Train = true;
            foreach (string id in list)
            {
                foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                {
                    if (t.ScheduleID.Equals(id) && (Train || t.TrainName.Equals(TrainName)))
                    {
                        foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                        {
                            if (ti.TrainID.Equals(t.TrainID) && ti.Booked == true) result++;
                        }
                    }
                }
            }
            return result;
        }
        public void GetStation(string userName, ref List<string> cbbDep, ref List<string> cbbDes)
        {
            PBL3 db = new PBL3();
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                {
                    if (t.ScheduleID.Equals(s.ScheduleID))
                    {
                        foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                        {
                            if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName))
                            {
                                cbbDep.Add(s.Departure);
                                cbbDes.Add(s.Destination);
                            }
                        }
                    }
                }
            }
        }
        public List<string> GetDeparture(string userName, string Destination)
        {
            PBL3 db = new PBL3();
            List<string> result = new List<string>();
            if (Destination != "")
                foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
                {
                    if (s.Destination.Equals(Destination))
                        foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                        {
                            if (t.ScheduleID.Equals(s.ScheduleID))
                            {
                                foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                                {
                                    if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName))
                                    {
                                        result.Add(s.Departure);
                                    }
                                }
                            }
                        }
                }
            else
                foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
                {
                    foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                    {
                        if (t.ScheduleID.Equals(s.ScheduleID))
                        {
                            foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                            {
                                if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName))
                                {
                                    result.Add(s.Departure);
                                }
                            }
                        }
                    }
                }
            return result;
        }
        public List<string> GetDestination(string userName, string Departure)
        {
            PBL3 db = new PBL3();
            List<string> result = new List<string>();
            if (Departure != "")
                foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
                {
                    if (s.Departure.Equals(Departure))
                        foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                        {
                            if (t.ScheduleID.Equals(s.ScheduleID))
                            {
                                foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                                {
                                    if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName))
                                    {
                                        result.Add(s.Destination);
                                    }
                                }
                            }
                        }
                }
            else
                foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
                {
                    foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                    {
                        if (t.ScheduleID.Equals(s.ScheduleID))
                        {
                            foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                            {
                                if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName))
                                {
                                    result.Add(s.Destination);
                                }
                            }
                        }
                    }
                }
            return result;
        }
        public void GetStation(ref List<string> cbbDep, ref List<string> cbbDes)
        {
            PBL3 db = new PBL3();
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                cbbDep.Add(s.Departure);
                cbbDes.Add(s.Destination);
            }
        }
        public List<string> GetDeparture(string Destination)
        {
            PBL3 db = new PBL3();
            List<string> result = new List<string>();
            if (Destination != "")
                foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
                {
                    if (s.Destination.Equals(Destination))
                        result.Add(s.Departure);
                }
            else
                foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
                {
                    result.Add(s.Departure);
                }
            return result;
        }
        public List<string> GetDestination(string Departure)
        {
            PBL3 db = new PBL3();
            List<string> result = new List<string>();
            if (Departure != "")
                foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
                {
                    if (s.Departure.Equals(Departure))
                        result.Add(s.Destination);
                }
            else
                foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
                {
                    result.Add(s.Destination);
                }
            return result;
        }
        public List<SCHEDULE> GetSchedule(string userName)
        {
            PBL3 db = new PBL3();
            List<SCHEDULE> result = new List<SCHEDULE>();
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                {
                    if (t.ScheduleID.Equals(s.ScheduleID))
                    {
                        foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                        {
                            if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName)) result.Add(s);
                        }
                    }
                }
            }
            return result;
        }
        public string GetSchedule(string userName, string day, string month, string year)
        {
            PBL3 db = new PBL3();
            string result = "";
            string date = day + "/" + month + "/" + year;
            bool UngetSchedule = true;
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                if (s.DepartureTime.Contains(date))
                {
                    foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                    {
                        if (t.ScheduleID.Equals(s.ScheduleID))
                        {
                            foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                            {
                                if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName))
                                {
                                    result += "\n";
                                    result += "Ga đi: " + s.Departure + "\n";
                                    result += "Ga đến: " + s.Destination + "\n";
                                    result += "Thời gian khởi hành:\n" + s.DepartureTime + "\n";
                                    result += "Thời gian đến:\n" + s.ArrivalTime + "\n";
                                    UngetSchedule = false;
                                    break;
                                }
                            }
                            if (UngetSchedule == false)
                            {
                                UngetSchedule = true;
                                break;
                            }
                        }

                    }
                }
            }
            return result;
        }
        public List<SCHEDULE> GetSchedule(SCHEDULE schedule, string userName)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            List<SCHEDULE> result = new List<SCHEDULE>();
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                if ((Dep || s.Departure.Equals(schedule.Departure)) && (Des || s.Destination.Equals(schedule.Destination))
                    && s.DepartureTime.Contains(schedule.DepartureTime) && s.ArrivalTime.Contains(schedule.ArrivalTime))
                {
                    foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                    {
                        if (t.ScheduleID.Equals(s.ScheduleID))
                        {
                            foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                            {
                                if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName)) result.Add(s);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public List<SCHEDULE> GetSchedule()
        {
            PBL3 db = new PBL3();
            return DALTRAIN.Instance.GetAllSCHEDULE();
        }
        public List<SCHEDULE> GetSchedule(SCHEDULE schedule)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            List<SCHEDULE> result = new List<SCHEDULE>();
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                if ((Dep || s.Departure.Equals(schedule.Departure)) && (Des || s.Destination.Equals(schedule.Destination))
                    && s.DepartureTime.Contains(schedule.DepartureTime) && s.ArrivalTime.Contains(schedule.ArrivalTime))
                {
                    result.Add(s);
                }
            }
            return result;
        }
        public List<int> GetDayOfDepartureTime(string month, string year, string userName)
        {
            PBL3 db = new PBL3();
            List<int> result = new List<int>();
            string date = month + "/" + year;
            foreach (SCHEDULE s in DALTRAIN.Instance.GetAllSCHEDULE())
            {
                if (s.DepartureTime.Contains(date))
                {
                    foreach (TRAIN t in DALTRAIN.Instance.GetAllTRAIN())
                    {
                        if (t.ScheduleID.Equals(s.ScheduleID))
                        {
                            foreach (TICKET ti in DALTRAIN.Instance.GetAllTICKET())
                            {
                                if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN.Equals(userName)) result.Add(Convert.ToDateTime(s.DepartureTime).Day);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
