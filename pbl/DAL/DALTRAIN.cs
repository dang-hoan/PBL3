using pbl.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.DAL
{
    public class DALTRAIN
    {
        private static DALTRAIN _Instance;
        public static DALTRAIN Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DALTRAIN();
                }
                return _Instance;
            }
            private set { }
        }
        private DALTRAIN()
        {

        }
        public string CheckAccount(string Username, string Password)
        {
            if (DBHelper.Instance.GetRecord($"select * from LOGIN where Username = '{Username}' and Password = '{Password}'", null).Rows.Count > 0)
            {
                return DBHelper.Instance.GetRecord
                    ("select Position " +
                     "from POSITION inner join PEOPLE on POSITION.PositionID = PEOPLE.PositionID " +
                    $"where Username = '{Username}'"
                    , null).Rows[0][0].ToString();
            }
            else return "Không tồn tại";
        }
        public void AddPEOPLE(PEOPLE p)
        {
            //insert into
        }
        public int UpdatePEOPLE(PEOPLE p)
        {
            return DBHelper.Instance.ExecuteDB("update PEOPLE set " +
                $"Name = N'{p.Name}' " +
                $"Gender = '{((p.Gender.Equals("Nam"))?true:false)}' " +
                $"BirthDay = '{p.BirthDay.ToString("yyyy/MM/dd HH:mm:ss")}' " +
                $"Address = N'{p.Address}' " +
                $"IDCard = '{p.IDCard}' " +
                $"Email = '{p.Email}' " +
                $"Phone = '{p.Phone}' " +
                $"where Username = '{p.Username}'", null);
        }
        public int UpdatePass(string userName, string oldPassword, string newPassword)
        {
            return DBHelper.Instance.ExecuteDB("update LOGIN set " +
                $"Password = '{newPassword}' " +
                $"where Username = '{userName}' and Password = '{oldPassword}'", null);
        }
        public void DeletePEOPLE(string Username)
        {
            DBHelper.Instance.ExecuteDB($"delete from PEOPLE where Username = '{Username}'", null);
        }
        //getAllPosition
        public List<POSITION> GetAllPOSITION()
        {
            List<POSITION> result = new List<POSITION>();
            DataTable dt = DBHelper.Instance.GetRecord("select * from POSITION", null);
            foreach(DataRow dr in dt.Rows)
            {
                result.Add(GetPOSITIONByDataRow(dr));
            }
            return result;
        }
        public POSITION GetPOSITIONByDataRow(DataRow i)
        {
            return new POSITION
            {
                PositionID = i["PositionID"].ToString(),
                Position = i["Position"].ToString()
            };
        }
        //getAllPeople
        public List<PEOPLE> GetAllPEOPLE()
        {
            List<PEOPLE> p = new List<PEOPLE>();
            DataTable dt = DBHelper.Instance.GetRecord("select * from PEOPLE", null);
            foreach(DataRow dr in dt.Rows)
            {
                p.Add(GetPEOPLEByDataRow(dr));
            }
            return p;
        }
        public PEOPLE GetPEOPLEByDataRow(DataRow i)
        {
            return new PEOPLE
            {
                Username = i[0].ToString(),
                Name = i[1].ToString(),
                Gender = (Convert.ToBoolean(i[2].ToString())) ? "Nam" : "Nữ",
                BirthDay = Convert.ToDateTime(i[3].ToString()),
                Address = i[4].ToString(),
                IDCard = i[5].ToString(),
                Email = i[6].ToString(),
                Phone = i[7].ToString(),
                PositionID = i[8].ToString()
            };
        }
        //getAllSchedule
        public List<SCHEDULE> GetAllSCHEDULE()
        {
            List<SCHEDULE> p = new List<SCHEDULE>();
            DataTable dt = DBHelper.Instance.GetRecord("select * from SCHEDULE", null);
            foreach (DataRow dr in dt.Rows)
            {
                p.Add(GetSCHEDULEByDataRow(dr));
            }
            return p;
        }
        public SCHEDULE GetSCHEDULEByDataRow(DataRow i)
        {
            return new SCHEDULE
            {
                ScheduleID = i[0].ToString(),
                Departure = i[1].ToString(),
                Destination = i[2].ToString(),
                DepartureTime = Convert.ToDateTime(i[3]).ToString("d/M/yyyy H:m:s"),
                ArrivalTime = Convert.ToDateTime(i[4]).ToString("d/M/yyyy H:m:s")
            };
        }
        //getAllTicket
        public List<TICKET> GetAllTICKET()
        {
            List<TICKET> p = new List<TICKET>();
            DataTable dt = DBHelper.Instance.GetRecord("select * from TICKET", null);
            foreach (DataRow dr in dt.Rows)
            {
                p.Add(GetTICKETByDataRow(dr));
            }
            return p;
        }
        public TICKET GetTICKETByDataRow(DataRow i)
        {
            return new TICKET
            {
                TicketID = i[0].ToString(),
                TrainID = i[1].ToString(),
                SeatNo = i[2].ToString(),
                TicketPrice = i[3].ToString(),
                Booked = Convert.ToBoolean(i[4].ToString()),
                CustomerUN = i[5].ToString()
            };
        }
        //getAllTrain
        public List<TRAIN> GetAllTRAIN()
        {
            List<TRAIN> p = new List<TRAIN>();
            DataTable dt = DBHelper.Instance.GetRecord("select * from TRAIN", null);
            foreach (DataRow dr in dt.Rows)
            {
                p.Add(GetTRAINByDataRow(dr));
            }
            return p;
        }
        public TRAIN GetTRAINByDataRow(DataRow i)
        {
            return new TRAIN
            {
                TrainID = i[0].ToString(),
                TrainName = i[1].ToString(),
                NumberOfCarriages = Convert.ToInt32(i[2].ToString()),
                DriverUN = i[3].ToString(),
                ScheduleID = i[4].ToString()
            };
        }
        //setTicket
        public void SetTicket(string TicketID, string userName, bool booked)
        {
            if (booked)
            {
                DBHelper.Instance.ExecuteDB("update TICKET set " +
                   $"CustomerUN = '{userName}', " +
                    "Booked = 'true' " +
                   $"where TicketID = '{TicketID}'", null);
            }
            else
            {
                DBHelper.Instance.ExecuteDB("update TICKET set " +
                    "CustomerUN = NULL, " +
                    "Booked = 'false' " +
                   $"where TicketID = '{TicketID}'", null);
            }
        }
    }
}
