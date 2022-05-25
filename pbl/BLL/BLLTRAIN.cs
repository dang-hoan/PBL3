﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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
        //Đọc ghi file
        private string Edit(string s, int total)
        {
            int x = (total - s.Length)/2;
            string result = "", temp = "";
            for (int i = 0; i < x; i++) temp += ' ';
            result += temp + s + temp;
            if ((total - s.Length) % 2 == 1) result += ' ';
            return result;
        }
        public void Print(DataGridView dataGridView1, int[] numberChar)
        {
            string path = null;
            OpenFileDialog o = new OpenFileDialog();
            o.InitialDirectory = "c:\\";
            //o.Multiselect = true;
            //o.Filter = " Doc|*.docx | Text(*.txt)|*.txt | All files (*.*)|*.*";
            o.Filter = " Text(*.txt)|*.txt";
            o.FilterIndex = 3;

            DialogResult r = o.ShowDialog();
            if (r == DialogResult.Cancel) return;
            path = o.FileName;
            int sum = 0;
            foreach (int i in numberChar) sum += i;

            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int k = 0; k < sum + dataGridView1.Columns.Count + 1; k++) sw.Write('-');
                sw.WriteLine();
                for (int i = 0; i < dataGridView1.Columns.Count; i++) sw.Write("|" + Edit(dataGridView1.Columns[i].Name, numberChar[i]));
                sw.Write("|\n");
                foreach (DataGridViewRow dr in dataGridView1.Rows)
                {
                    for (int k = 0; k < sum + dataGridView1.Columns.Count + 1; k++) sw.Write('-');
                    sw.WriteLine();
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        sw.Write("|" + Edit(dr.Cells[i].Value.ToString(), numberChar[i]));
                    }
                    sw.Write("|\n");
                }
                for (int k = 0; k < sum + dataGridView1.Columns.Count + 1; k++) sw.Write('-');
                MessageBox.Show("Đã xuất dữ liệu ra file bạn chọn!");
            }
        }
        //Chung
        public bool check(string username)
        {
            PBL3 db = new PBL3();
            foreach (PEOPLE i in db.PEOPLE)
            {
                if (i.Username == username) return true;
            }
            return false;
        }
        public void Execute(PEOPLE s)
        {
            PBL3 db = new PBL3();
            if (!check(s.Username))
            {
                db.PEOPLE.Add(s);
                db.SaveChanges();
            }
            else
            {
                PEOPLE temp = db.PEOPLE.Find(s.Username);
                temp.Name = s.Name;
                temp.Gender = s.Gender;
                temp.BirthDay = s.BirthDay;
                temp.Phone = s.Phone;
                temp.Address = s.Address;
                temp.IDCard = s.IDCard;
                temp.Email = s.Email;
                db.SaveChanges();
            }

        }
        public void Execute(SCHEDULE s)
        {
            PBL3 db = new PBL3();

            db.SCHEDULEs.Add(s);
            db.SaveChanges();
            
        }
        public PEOPLE GetuserByusername(string username)
        {
            PBL3 db = new PBL3();
            return db.PEOPLE.Find(username);

        }
        public string CheckAccount(string Username, string Password)
        {
            PBL3 db = new PBL3();
            foreach(LOGIN log in db.LOGINs)
            {
                if(log.Username.Equals(Username) && log.PassWord.Equals(Password))
                {
                    var result = from pos in db.POSITIONs
                                 join peo in db.PEOPLE on pos.PositionID equals peo.PositionID
                                 where peo.Username.Equals(Username)
                                 select pos.Position;
                    return result.FirstOrDefault();
                }
            }
            return "Không tồn tại";
        }

        public void Add()
        {
            PBL3 db = new PBL3();

        }
        public void UpdatePEOPLE(PEOPLE p)
        {
            PBL3 db = new PBL3();
            PEOPLE peo = db.PEOPLE.Find(p.Username);
            peo.Name = p.Name;
            peo.Gender = p.Gender;
            peo.BirthDay = p.BirthDay;
            peo.Address = p.Address;
            peo.IDCard = p.IDCard;
            peo.Email = p.Email;
            peo.Phone = p.Phone;
            db.SaveChanges();
        }
        public bool UpdatePass(string userName, string oldPassword, string newPassword)
        {
            PBL3 db = new PBL3();
            LOGIN l = (from log in db.LOGINs
                        where log.Username.Equals(userName) && log.PassWord.Equals(oldPassword)
                        select log).FirstOrDefault();
            if (l == null) return false;
            else
            {
                l.PassWord = newPassword;
                db.SaveChanges();
                return true;
            }
        }
        public void UpdatePassByForget(string userName, string newPassword)
        {
            PBL3 db = new PBL3();
            LOGIN l = (from log in db.LOGINs
                        where log.Username.Equals(userName)
                        select log).FirstOrDefault();
            l.PassWord = newPassword;
            db.SaveChanges();
        }
        public bool CheckSecurity(string userName, string question, string answer)
        {
            PBL3 db = new PBL3();
            SECURITY s = (from sec in db.SECURITies
                          where sec.OwnUN.Equals(userName) && sec.Question.Equals(question) && sec.Answer.Equals(answer)
                          select sec).FirstOrDefault();
            if(s == null) return false;
            return true;
        }
        public List<string> GetQuestionSecurity(string userName)
        {
            PBL3 db = new PBL3();
            var result = from sec in db.SECURITies
                         where sec.OwnUN.Equals(userName)
                         select sec.Question;
            return result.ToList();
        }
        public string GetAnswerSecurity(string userName, string question)
        {
            PBL3 db = new PBL3();
            var result = from sec in db.SECURITies
                         where sec.OwnUN.Equals(userName) && sec.Question.Equals(question)
                         select sec.Answer;
            return result.ToList().FirstOrDefault();
        }
        public void UpdateSecurity(string userName, string question, string newAnswer)
        {
            PBL3 db = new PBL3();
            SECURITY s = (from sec in db.SECURITies
                          where sec.OwnUN.Equals(userName) && sec.Question.Equals(question)
                          select sec).FirstOrDefault();
            s.Answer = newAnswer;
            db.SaveChanges();
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

            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         join PEOPLE peo in db.PEOPLE on tic.CustomerUN equals peo.Username into TIC_PEO_Group
                         from ticpeo in TIC_PEO_Group.DefaultIfEmpty()
                         select new TICKET_View
                         {
                             ScheduleID = tra.ScheduleID,
                             TrainID = tra.TrainID.ToString(),
                             TrainName = tra.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = tic.TicketPrice.ToString(),
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString(),
                             Booked = ( bool)tic.Booked ? "đã đặt" : "chưa đặt",
                             OwnUsername = (ticpeo == null)? "" : tic.CustomerUN,
                             OwnName = (ticpeo == null) ? "" : ticpeo.Name
                       };
            return result.ToList();
        }
        public List<PEOPLE_View> GetAllPEOPLEView()
        {
            PBL3 db = new PBL3();
            var result = from PEOPLE peo in db.PEOPLE
                         join POSITION pos in db.POSITIONs on peo.PositionID equals pos.PositionID
                         select new PEOPLE_View
                         {
                             Username = peo.Username,
                             Name = peo.Name,
                             Gender = ((bool)peo.Gender) ? "Nam" : "Nữ",
                             BirthDay = (peo.BirthDay == null)?DateTime.Now:(DateTime)peo.BirthDay,
                             Address = peo.Address,
                             IDCard = peo.IDCard,
                             Email = peo.Email,
                             Phone = peo.Phone,
                             Position = pos.Position
                         };
            return result.ToList();
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
            var result = from peo in db.PEOPLE
                         where peo.Username.Equals(Username)
                         select peo.Name;
            return result.FirstOrDefault();
        }
        public List<TICKET_User_View> GetTicket(string userName)
        {
            PBL3 db = new PBL3();
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         join PEOPLE peo in db.PEOPLE on tic.CustomerUN equals peo.Username
                         where tic.CustomerUN == userName
                         select new TICKET_User_View
                         {
                             ScheduleID = tra.ScheduleID,
                             TrainID = tra.TrainID.ToString(),
                             TrainName = tra.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = tic.TicketPrice.ToString(),
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }
        public List<TICKET_User_View> GetTicket(SCHEDULE_View schedule, string userName, string TrainName)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false, Train = false;
            if (schedule.Departure == "") Dep = true;
            if (TrainName == "") Train = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where (Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination))
                               && sch.DepartureTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.DepartureTime)
                               && sch.ArrivalTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.ArrivalTime)
                               && (Train || tra.TrainName.Equals(TrainName)) && tic.CustomerUN == userName
                         select new TICKET_User_View
                         {
                             ScheduleID = tra.ScheduleID,
                             TrainID = tra.TrainID.ToString(),
                             TrainName = tra.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = tic.TicketPrice.ToString(),
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }
        public List<TICKET_User_View> GetTicket( string userName, string TrainName)
        {
            PBL3 db = new PBL3();
            bool Train = false;
            if (TrainName == "") Train = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where (Train || tra.TrainName.Equals(TrainName)) && tic.CustomerUN == userName
                         select new TICKET_User_View
                         {
                             ScheduleID = tra.ScheduleID,
                             TrainID = tra.TrainID.ToString(),
                             TrainName = tra.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = tic.TicketPrice.ToString(),
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }
        public List<TICKET_User_View> GetTicket(SCHEDULE_BLL schedule, string userName, string TrainName)
        {
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            PBL3 db = new PBL3();
            bool Dep = false, Des = false, Train = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            if (TrainName == "") Train = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where (Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination))
                               && (DateTime.Compare(schedule.FromDepartureTime, sch.DepartureTime) <= 0 && DateTime.Compare(sch.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, sch.ArrivalTime) <= 0 && DateTime.Compare(sch.ArrivalTime, schedule.ToArrivalTime) <= 0)                               
                               && (Train || tra.TrainName.Equals(TrainName)) && tic.CustomerUN == userName
                         select new TICKET_User_View
                         {
                             ScheduleID = tra.ScheduleID,
                             TrainID = tra.TrainID.ToString(),
                             TrainName = tra.TrainName,
                             TicketID = tic.TicketID,
                             SeatNo = tic.SeatNo,
                             TicketPrice = tic.TicketPrice.ToString(),
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
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
                        if (bool.Parse(t.Booked)) booked++;
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
            var result = from tra in db.TRAINs
                         join tic in db.TICKETs on tra.TrainID equals tic.TrainID
                         where tic.CustomerUN == userName
                         select tra.TrainName;
            return result.ToList();
        }
        public List<Train_View> GetTrain2(string schedule)
        {
            PBL3 db = new PBL3();
            List<Train_View> data = new List<Train_View>();
            foreach (TRAIN i in GettrainBytrainid(schedule))
            {

                data.Add(new Train_View
                {
                    TrainID = i.TrainID.ToString(),
                    TrainName= i.TrainName,
                    NumberOfCarriages = i.NumberOfCarriages.ToString(),
                    DriverUN = i.DriverUN,
                    ScheduleID = i.ScheduleID,
                    BasicPrice = i.BasicPrice.ToString(),
                    State = i.State.ToString()
                });
            }
            return data;
        }
       public List<TRAIN> trainaddve(int trainid)
        {
            PBL3 db = new PBL3();
            List<TRAIN> data = new List<TRAIN>();
            data = db.TRAINs.Where(p => (p.TrainID == trainid)).Select(p => p).ToList();
            return data;
        }
        public List<TRAIN> GettrainBytrainid(string scheduleid)
        {
            PBL3 db = new PBL3();
            List<TRAIN> data = new List<TRAIN>();
           
            
                data = db.TRAINs.Where(p => (p.ScheduleID == scheduleid) ).Select(p => p).ToList();
            
            return data;
        }
        public List<string> GetTrain(SCHEDULE_View schedule, string userName)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where (Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination))
                               && sch.DepartureTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.DepartureTime)
                               && sch.ArrivalTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.ArrivalTime)
                               && tic.CustomerUN == userName
                         select tra.TrainName;
            return result.ToList();
        }
        public List<string> GetTrain(SCHEDULE_BLL schedule, string userName)
        {
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where (Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination))
                               && (DateTime.Compare(schedule.FromDepartureTime, sch.DepartureTime) <= 0 && DateTime.Compare(sch.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, sch.ArrivalTime) <= 0 && DateTime.Compare(sch.ArrivalTime, schedule.ToArrivalTime) <= 0)
                               && tic.CustomerUN == userName
                         select tra.TrainName;
            return result.ToList();
        }
        public List<string> GetTrain(List<string> list)
        {
            PBL3 db = new PBL3();
            List<string> result = new List<string>();
            foreach (string id in list)
            {
                foreach (TRAIN t in db.TRAINs)
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
            TICKET tic = db.TICKETs.Find(TicketID);
            if (booked)
            {
                tic.Booked = true;
                tic.CustomerUN = userName;
            }
            else
            {
                tic.Booked = false;
                tic.CustomerUN = null;
            }
            db.SaveChanges();
        }
        public int GetNumberOfCarriages(string TrainName)
        {
            PBL3 db = new PBL3();
            int result = 25;
            if (TrainName == "")
                return result; 
            foreach (TRAIN t in db.TRAINs)
            {
                if (t.TrainName.Equals(TrainName))
                    result = t.NumberOfCarriages;
            }
            return result;
        }
        public int GetNumberBooked(List<string> list, string TrainName)
        {
            PBL3 db = new PBL3();
            int result = 0;
            bool Train = false;
            if (TrainName == "") Train = true;
            foreach (string id in list)
            {
                foreach (TRAIN t in db.TRAINs)
                {
                    if (t.ScheduleID.Equals(id) && (Train || t.TrainName.Equals(TrainName)))
                    {
                        foreach (TICKET ti in db.TICKETs.ToList())
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
            cbbDep = (from sch in db.SCHEDULEs.ToList()
                     join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                     join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                     where tic.CustomerUN == userName
                     select sch.Departure).ToList();
            cbbDes = (from sch in db.SCHEDULEs.ToList()
                     join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                     join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                     where tic.CustomerUN == userName
                     select sch.Destination).ToList();
        }
        public List<string> GetDeparture(string userName, string Destination)
        {
            PBL3 db = new PBL3();
            if(Destination != "")
                return (from sch in db.SCHEDULEs.ToList()
                       join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                       join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                       where tic.CustomerUN == userName && sch.Destination.Equals(Destination)
                       select sch.Departure).ToList();
            else
                return (from sch in db.SCHEDULEs.ToList()
                        join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                        join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                        where tic.CustomerUN == userName
                        select sch.Departure).ToList();
        }
        public List<string> GetDestination(string userName, string Departure)
        {
            PBL3 db = new PBL3();
            if (Departure != "")
                return (from sch in db.SCHEDULEs.ToList()
                        join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                        join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                        where tic.CustomerUN == userName && sch.Departure.Equals(Departure)
                        select sch.Destination).ToList();
            else
                return (from sch in db.SCHEDULEs.ToList()
                        join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                        join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                        where tic.CustomerUN == userName
                        select sch.Destination).ToList();
        }
        //public List<string> GetDeparture2(string userName, string Departure)
        //{
        //    PBL3 db = new PBL3();
        //    if (Departure != "")
        //        return (from sch in db.SCHEDULEs.ToList()
        //                join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
        //                join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
        //                where tic.CustomerUN == userName && sch.Departure.Contains(Departure)
        //                select sch.Departure).ToList();
        //    else
        //        return (from sch in db.SCHEDULEs.ToList()
        //                join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
        //                join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
        //                where tic.CustomerUN == userName
        //                select sch.Departure).ToList();
        //}
        //public List<string> GetDestination2(string userName, string Destination)
        //{
        //    PBL3 db = new PBL3();
        //    if (Destination != "")
        //        return (from sch in db.SCHEDULEs.ToList()
        //                join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
        //                join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
        //                where tic.CustomerUN == userName && sch.Destination.Contains(Destination)
        //                select sch.Destination).ToList();
        //    else
        //        return (from sch in db.SCHEDULEs.ToList()
        //                join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
        //                join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
        //                where tic.CustomerUN == userName
        //                select sch.Destination).ToList();
        //}
        public void GetStation(ref List<string> cbbDep, ref List<string> cbbDes)
        {
            PBL3 db = new PBL3();
            cbbDep = (from sch in db.SCHEDULEs.ToList()
                      select sch.Departure).ToList();
            cbbDes = (from sch in db.SCHEDULEs.ToList()
                      select sch.Destination).ToList();
        }
        public List<CBBpeople> GetAllCBBPeople()
        {
            PBL3 db = new PBL3();
            return (from i in db.PEOPLE.ToList()                     
                       select new CBBpeople
                       {
                           Value = i.Username,
                           Text = i.Name
                       }).ToList();

        }
        public List<string> GetDeparture(string Destination)
        {
            PBL3 db = new PBL3();
            if (Destination != "")
                return (from sch in db.SCHEDULEs.ToList()
                        where sch.Destination.Equals(Destination)
                        select sch.Departure).ToList();
            else
                return (from sch in db.SCHEDULEs.ToList()
                        select sch.Departure).ToList();
        }
        public List<string> GetDestination(string Departure)
        {
            PBL3 db = new PBL3();
            if (Departure != "")
                return (from sch in db.SCHEDULEs.ToList()
                        where sch.Departure.Equals(Departure)
                        select sch.Destination).ToList();
            else
                return (from sch in db.SCHEDULEs.ToList()
                        select sch.Destination).ToList();
        }
        public bool checksch(string scheduleid)
        {
            PBL3 db = new PBL3();
            foreach (SCHEDULE i in db.SCHEDULEs)
            {
                if (i.ScheduleID == scheduleid) return true;
            }
            return false;
        }
        public bool checktrain(int trainid)
        {
            PBL3 db = new PBL3();
            foreach (TRAIN i in db.TRAINs)
            {
                if (i.TrainID == trainid) return false;
            }
            return true;
        }
        public List<SCHEDULE_View> GetSchedule(string userName)
        {
            PBL3 db = new PBL3();
            var result = from sch in db.SCHEDULEs.ToList()
                         join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where tic.CustomerUN == userName
                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList().GroupBy(s => s.ScheduleID).Select(g => g.First()).ToList();
        }
        public string GetSchedule(string userName, string day, string month, string year)
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("nl");
            PBL3 db = new PBL3();
            string result = "";
            string date = day + "-" + month + "-" + year;
            bool UngetSchedule = true;
            foreach (SCHEDULE s in db.SCHEDULEs.ToList())
            {
                if (s.DepartureTime.ToString("d-M-yyyy H:m:s").Contains(date))
                {
                    foreach (TRAIN t in db.TRAINs)
                    {
                        if (t.ScheduleID.Equals(s.ScheduleID))
                        {
                            foreach (TICKET ti in db.TICKETs.ToList())
                            {
                                if (ti.TrainID.Equals(t.TrainID) && ti.CustomerUN == userName)
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
        
        public List<SCHEDULE_View> GetSchedule(SCHEDULE_View schedule, string userName)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where (Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination))
                               && sch.DepartureTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.DepartureTime)
                               && sch.ArrivalTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.ArrivalTime)
                               && tic.CustomerUN == userName
                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList().GroupBy(s => s.ScheduleID).Select(g => g.First()).ToList();
        }
        public List<SCHEDULE_View> GetSchedule(SCHEDULE_BLL schedule, string userName)
        {
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         join TRAIN tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join TICKET tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where (Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination))
                               && (DateTime.Compare(schedule.FromDepartureTime, sch.DepartureTime) <= 0 && DateTime.Compare(sch.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, sch.ArrivalTime) <= 0 && DateTime.Compare(sch.ArrivalTime, schedule.ToArrivalTime) <= 0)
                               && tic.CustomerUN == userName
                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList().GroupBy(s => s.ScheduleID).Select(g => g.First()).ToList();
        }
        public List<SCHEDULE_View> GetSchedule()
        {
            PBL3 db = new PBL3();
            return (from sch in db.SCHEDULEs.ToList()
                    select new SCHEDULE_View
                    {
                        ScheduleID = sch.ScheduleID,
                        Departure = sch.Departure,
                        Destination = sch.Destination,
                        DepartureTime = sch.DepartureTime.ToString(),
                        ArrivalTime = sch.ArrivalTime.ToString()
                    }).ToList();
        }
        public List<SCHEDULE> GetScheduleid( string scheduleid)
        {  PBL3 db = new PBL3();
            List<SCHEDULE> data = new List<SCHEDULE>();
            data = db.SCHEDULEs.Where(p => (p.ScheduleID == scheduleid)).Select(p => p).ToList();
            return data;
        }
        public void Executetrain(TRAIN s)
        {
            PBL3 db = new PBL3();
            db.TRAINs.Add(s);
            db.SaveChanges();
            

        }
        public List<Train_View> Getalltrain()
        {
            PBL3 db = new PBL3();
            return (from tra in db.TRAINs.ToList()
                    select new Train_View
                    {
                        ScheduleID = tra.ScheduleID,
                        TrainID = tra.TrainID.ToString(),
                        TrainName = tra.TrainName,
                        NumberOfCarriages = tra.NumberOfCarriages.ToString(),
                        DriverUN = tra.DriverUN.ToString(),
                        BasicPrice = tra.BasicPrice.ToString(),
                        State = tra.State.ToString(),
                    }).ToList();
        }

        public List<SCHEDULE_View> GetSchedule(SCHEDULE_View schedule)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         where (Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination))
                               && sch.DepartureTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.DepartureTime)
                               && sch.ArrivalTime.ToString("dd/MM/yyyy H:m:s").Contains(schedule.ArrivalTime)
                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }
        public List<SCHEDULE_View> GetSchedule(SCHEDULE_BLL schedule)
        {
            schedule.FromDepartureTime = schedule.FromDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second);
            schedule.ToDepartureTime = schedule.ToDepartureTime.AddSeconds(-schedule.FromDepartureTime.Second + 59);
            schedule.FromArrivalTime = schedule.FromArrivalTime.AddSeconds(-schedule.FromArrivalTime.Second);
            schedule.ToArrivalTime = schedule.ToArrivalTime.AddSeconds(-schedule.ToArrivalTime.Second + 59);
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         where (Dep || sch.Departure.Equals(schedule.Departure)) && (Des || sch.Destination.Equals(schedule.Destination))
                               && (DateTime.Compare(schedule.FromDepartureTime, sch.DepartureTime) <= 0 && DateTime.Compare(sch.DepartureTime, schedule.ToDepartureTime) <= 0)
                               && (DateTime.Compare(schedule.FromArrivalTime, sch.ArrivalTime) <= 0 && DateTime.Compare(sch.ArrivalTime, schedule.ToArrivalTime) <= 0)
                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }
        public List<SCHEDULE_View> GetSchedule2(SCHEDULE_View schedule)
        {
            PBL3 db = new PBL3();
            bool Dep = false, Des = false;
            if (schedule.Departure == "") Dep = true;
            if (schedule.Destination == "") Des = true;
            //var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
            //             where (Dep || sch.Departure.Equals(schedule.Departure)) || (Des || sch.Destination.Equals(schedule.Destination))
            //                   && sch.DepartureTime.ToString("d/M/yyyy H:m:s").Contains(schedule.DepartureTime)
            var result = from SCHEDULE sch in db.SCHEDULEs.ToList()
                         where( (sch.Departure.Equals(schedule.Departure)) && ( sch.Destination.Equals(schedule.Destination)))
                         select new SCHEDULE_View
                         {
                             ScheduleID = sch.ScheduleID,
                             Departure = sch.Departure,
                             Destination = sch.Destination,
                             DepartureTime = sch.DepartureTime.ToString(),
                             ArrivalTime = sch.ArrivalTime.ToString()
                         };
            return result.ToList();
        }

        public void delschedule(string scheduleid)
        {
            PBL3 db = new PBL3();
            SCHEDULE s = db.SCHEDULEs.Find(scheduleid);
            db.SCHEDULEs.Remove(s);
            //TRAIN f = db.TRAINs.Where(p => p.ScheduleID == scheduleid).Single();
            //string train = f.TrainID;
            //TICKET dn = new TICKET();
            //dn = db.TICKETs.Where(p => p.TrainID == train).Single();
            List<string> vs = new List<string>();
            foreach(String i in db.TRAINs.Where(p => p.ScheduleID == scheduleid).Select(p => p.TrainID.ToString()).ToList())
            {
                vs.Add(i);
            }
            foreach(TRAIN i in db.TRAINs.Where(p => p.ScheduleID == scheduleid))
            {
                db.TRAINs.Remove(i);
            }
            foreach(string i in vs) 
            {
                TICKET t = db.TICKETs.Find(i);
                db.TICKETs.Remove(t);
            }
        
            
            db.SaveChanges();
        }
        public List<int> GetDayOfDepartureTime(string month, string year, string userName)
        {
            PBL3 db = new PBL3();
            string date = month + "-" + year;
            var result = from sch in db.SCHEDULEs.ToList()
                         join tra in db.TRAINs on sch.ScheduleID equals tra.ScheduleID
                         join tic in db.TICKETs.ToList() on tra.TrainID equals tic.TrainID
                         where sch.DepartureTime.ToString("d-M-yyyy H:m:s").Contains(date) && tic.CustomerUN == userName
                         select sch.DepartureTime.Day;
            return result.ToList();
        }
      
    }
   
}
