using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public class ManageFunction
    {
        //Hoan
        private DBHelper db = new DBHelper(@"Data Source=DESKTOP-DKTP37G\CSDL;Initial Catalog=PBL3;User ID=Nhom4;Password=12345678");
        //Đức
        //private DBHelper db = new DBHelper(@"");
        //Phong
        //private DBHelper db = new DBHelper(@"Data Source=DESKTOP-5LQORUF;Initial Catalog=PBL3;Integrated Security=True");
        public int checkAccount(string userName, string passWord)
        {
            DataTable dt = new DataTable();
            string query = "select * from LOGIN";
            dt = db.GetRecord(query, null);
            foreach (DataRow i in dt.Rows)
            {
                if (i["Username"].ToString().Equals(userName) && i["PassWord"].ToString().Equals(passWord))
                {
                    string query2 = "select Position from POSITION inner join PEOPLE on POSITION.PositionID = PEOPLE.PositionID " +
                        "inner join LOGIN on PEOPLE.Username = LOGIN.Username where PEOPLE.Username = '" + i["Username"].ToString() + "'";
                    DataTable dt2 = db.GetRecord(query2, null);
                    if (dt2.Rows[0]["Position"].Equals("Giám đốc"))
                        return 1;
                    else if (dt2.Rows[0]["Position"].Equals("Nhân viên"))
                        return 2;
                    else return 3;
                }
            }
            return 0;
        }
        public DataTable getInfo(string UserName)
        {
            string query = "select PEOPLE.*, Position from PEOPLE inner join POSITION on POSITION.PositionID = PEOPLE.PositionID where Username = '" + UserName + "'";
            return db.GetRecord(query, null);
        }
        public bool setPass(string UserName, string passWord, string newPass)
        {
            string query2 = $"update LOGIN set PassWord = '{newPass}' where Username = '{UserName}' and PassWord = '{passWord}'";
            if (db.ExcuteDB(query2, null) != -1) return true;
            else return false;
        }
        public void setInfo(string UserName, string Name, bool Gender, string BirthDay, string Address, string IDCard, string Email, string Phone)
        {
            string query = $"update PEOPLE set" +
                $" Name = N'{Name}'" +
                $", Gender = '{Gender}'" +
                $", BirthDay = '{BirthDay}'" +
                $", Address = N'{Address}'" +
                $", IDCard = '{IDCard}'" +
                $", Email = '{Email}'" +
                $", Phone = '{Phone}'" +
                $" where Username = '{UserName}'";
            db.ExcuteDB(query, null);
        }


        //Passenger
        public string GetName(string UserName)
        {
            string query = "select Name from PEOPLE where UserName = '" + UserName + "'";
            return db.GetRecord(query, null).Rows[0][0].ToString();
        }
        public DataTable GetStation(string UserName)
        {
            string query = "select Departure, Destination from SCHEDULE inner join TRAIN on SCHEDULE.ScheduleID = TRAIN.ScheduleID " +
                "inner join TICKET on TRAIN.TrainID = TICKET.TrainID inner join PEOPLE on TICKET.CustomerUN = PEOPLE.Username " +
                "where Username = '" + UserName + "'";
            return db.GetRecord(query, null);
        }
        public DataTable GetStation()
        {
            string query = "select StationName from STATION";
            return db.GetRecord(query, null);
        }
        public DataTable GetSchedule(string UserName)
        {
            string query = "select SCHEDULE.* from SCHEDULE inner join TRAIN on SCHEDULE.ScheduleID = TRAIN.ScheduleID " +
                "inner join TICKET on TRAIN.TrainID = TICKET.TrainID inner join PEOPLE on TICKET.CustomerUN = PEOPLE.Username " +
                "where Username = '" + UserName + "'";
            return db.GetRecord(query, null);
        }
        public string GetSchedule(string day, string month, string year)
        {
            string result = ""; string s = ""; DataRow dr;
            string query = $"select * from SCHEDULE where day(DepartureTime) = {day} and month(DepartureTime) = {month} and year(DepartureTime) = {year}";
            DataTable dt = db.GetRecord(query, null);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                s = "\n";
                dr = dt.Rows[i];
                s += "Ga đi: " + dr[1] + "\n";
                s += "Ga đến: " + dr[2] + "\n";
                s += "Thời gian khởi hành:\n" + dr[3] + "\n";
                s += "Thời gian đến:\n" + dr[4] + "\n";
                result += s;
            }
            return result;
        }
        public DataTable GetSchedule(string UserName, string Departure, string Destination, bool Type, string DepartureTime, string ArrivalTime, bool hasInputDep, bool hasInputDes)
        {
            string dep, des;
            if (hasInputDep)   dep = $"= '{DepartureTime}'";
            else    dep = $"between '{DepartureTime + " 0:0"}' and '{DepartureTime + " 23:59"}'";
            if (hasInputDes)   des = $"= '{ArrivalTime}'";
            else des = $"between '{ArrivalTime + " 0:0"}' and '{ArrivalTime + " 23:59"}'";
            string query = "select SCHEDULE.* from SCHEDULE inner join TRAIN on SCHEDULE.ScheduleID = TRAIN.ScheduleID " +
                "inner join TICKET on TRAIN.TrainID = TICKET.TrainID inner join PEOPLE on TICKET.CustomerUN = PEOPLE.Username " +
                $"where Username = '{UserName}' and Departure like N'{Departure}%' and Destination like N'{Destination}%' and DepartureTime {dep} and ArrivalTime {des}";
            return db.GetRecord(query, null);
        }
        public DataTable GetSchedule(string Departure, string Destination, bool Type, string DepartureTime, string ArrivalTime, bool hasInputDep, bool hasInputDes)
        {
            string dep, des;
            if (hasInputDep) dep = $"= '{DepartureTime}'";
            else dep = $"between '{DepartureTime + " 0:0"}' and '{DepartureTime + " 23:59"}'";
            if (hasInputDes) des = $"= '{ArrivalTime}'";
            else des = $"between '{ArrivalTime + " 0:0"}' and '{ArrivalTime + " 23:59"}'";
            string query = "select SCHEDULE.* from SCHEDULE inner join TRAIN on SCHEDULE.ScheduleID = TRAIN.ScheduleID " +
                "inner join TICKET on TRAIN.TrainID = TICKET.TrainID inner join PEOPLE on TICKET.CustomerUN = PEOPLE.Username " +
                $"where Departure like N'{Departure}%' and Destination like N'{Destination}%' and DepartureTime {dep} and ArrivalTime {des}";
            return db.GetRecord(query, null);
        }
        public DataTable GetDepartureTime(string UserName)
        {
            string query = "select DepartureTime from SCHEDULE inner join TRAIN on SCHEDULE.ScheduleID = TRAIN.ScheduleID " +
                "inner join TICKET on TRAIN.TrainID = TICKET.TrainID inner join PEOPLE on TICKET.CustomerUN = PEOPLE.Username " +
                "where Username = '" + UserName + "'";
            return db.GetRecord(query, null);
        }
        public DataTable GetAllTicket(string UserName)
        {
            string query = "select * from TICKET where CustomerUN = '" + UserName + "'";
            return db.GetRecord(query, null);
        }
        public DataTable GetAllTicket()
        {
            string query = "select * from TICKET";
            return db.GetRecord(query, null);
        }
        private char[] Carriages = new char[26] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public DataTable GetTicket(string UserName, string Departure, string Destination, bool Type, string DepartureTime, string ArrivalTime, int TrainID, string Carriages)
        {
            string cari;
            if (Carriages == "") cari = "%";
            else cari = this.Carriages[Convert.ToInt32(Carriages) - 1] + "%";
            string query = "select TicketID, TrainName, SeatNo, TicketPrice from PEOPLE inner join TICKET on PEOPLE.Username = TICKET.CustomerUN inner join TRAIN on TICKET.TrainID = TRAIN.TrainID" +
                " inner join SCHEDULE on TRAIN.ScheduleID = SCHEDULE.ScheduleID where " +
                $" Departure like N'{Departure}%' and Destination like N'{Destination}%' and DepartureTime = '{DepartureTime}' and ArrivalTime = '{ArrivalTime}' and" +
                $" TRAIN.TrainID = '{TrainID + 1}' and SeatNo like '{cari}' and Username = '{UserName}'";
            return db.GetRecord(query, null);
        }
        public DataTable GetTicket(string Departure, string Destination, bool Type, string DepartureTime, string ArrivalTime, int TrainID, string Carriages)
        {
            string cari;
            if (Carriages == "") cari = "%";
            else cari = this.Carriages[Convert.ToInt32(Carriages) - 1] + "%";
            string query = "select TicketID, TrainName, SeatNo, TicketPrice from TICKET inner join TRAIN on TICKET.TrainID = TRAIN.TrainID" +
                " inner join SCHEDULE on TRAIN.ScheduleID = SCHEDULE.ScheduleID where " +
                $" Departure like N'{Departure}%' and Destination like N'{Destination}%' and DepartureTime = '{DepartureTime}' and ArrivalTime = '{ArrivalTime}' and" +
                $" TRAIN.TrainID = '{TrainID + 1}' and SeatNo like '{cari}'";
            return db.GetRecord(query, null);
        }
        public void SetTicket(string TicketID, string UserName, bool type)
        {
            string query;
            if (type)
            {
                query = "update TICKET set " +
                    "Booked = 'True', " +
                    "CustomerID = '" + UserName + "' " +
                    "where TicketID = '" + TicketID + "'";
            }
            else
            {
                query = "update TICKET set " +
                    "Booked = 'False', " +
                    "CustomerID = 'NULL' " +
                    "where TicketID = '" + TicketID + "'";
            }
            db.ExcuteDB(query, null);
        }
        public DataTable GetTrain()
        {
            string query = "select TrainName from TRAIN";
            return db.GetRecord(query, null);
        }
        public DataTable GetNumberOfCarriages(int TrainID)
        {
            string query = "select NumberOfCarriages from TRAIN where TrainID = '" + (TrainID + 1) + "'";
            DataTable dt = db.GetRecord(query, null);
            MessageBox.Show(dt.Rows[0][0].ToString());
            return dt;
        }
        public int GetNumberBooked(int TrainID, string Departure, string Destination, bool Type, string DepartureTime, string ArrivalTime)
        {
            string query = "select Booked from TICKET inner join TRAIN on TICKET.TrainID = TRAIN.TrainID" +
                " inner join SCHEDULE on TRAIN.ScheduleID = SCHEDULE.ScheduleID where " +
                $" Departure like N'{Departure}%' and Destination like N'{Destination}%' and DepartureTime = '{DepartureTime}' and ArrivalTime = '{ArrivalTime}' and" +
                $" TRAIN.TrainID = '{TrainID + 1}'";
            DataTable dt = db.GetRecord(query, null);
            int count = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToBoolean(dr[0])) count++;
            }
            return count;
        }


        //Admin
        public DataTable GetAllNV()
        {

            string query = "select * from PEOPLE where PositionID ='" + 222 + "'";

            return db.GetRecord(query, null);

        }
        public void Addnv(string Username, string Name, bool Gender, DateTime BirthDay, string Address, string IDCard, string Email, string Phone, string PositionID)
        {
            string query = $"INSERT INTO  PEOPLE VALUES ('{Username}',N'{Name}','{Gender}','{BirthDay}','{Address}','{IDCard}','{Email}','{Phone}','{PositionID}') ";
            db.ExcuteDB(query, null);
            //GetAllNV();
        }

    }
}
