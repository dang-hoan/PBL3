using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbl
{
    public class ManageFunction
    {
        private DBHelper db = new DBHelper(@"Data Source=DESKTOP-DKTP37G\CSDL;Initial Catalog=PBL3;User ID=Nhom4;Password=12345678");
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

        //Passenger
        public string GetName(string UserName)
        {
            string query = "select Name from PEOPLE where UserName = '" + UserName + "'";
            return db.GetRecord(query, null).Rows[0][0].ToString();
        }
        public string GetSchedule(string day, string month, string year)
        {
            string result = ""; string s = ""; DataRow dr;
            string query = $"select * from SCHEDULE where day(DepartureTime) = {day} and month(DepartureTime) = {month} and year(DepartureTime) = {year}";
            DataTable dt = db.GetRecord(query, null);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                s = "\n";
                dr = dt.Rows[i];
                s += "Ga đi: " + dr[1] + "\n";
                s += "Ga đến: " + dr[2] + "\n";
                s += "Thời gian khởi hành: " + dr[3] + "\n";
                s += "Thời gian đến: " + dr[4] + "\n";
                result += s;
            }
            return result;
        }
        public DataTable GetDepartureTime(string UserName)
        {
            string query = "select DepartureTime from SCHEDULE inner join TRAIN on SCHEDULE.ScheduleID = TRAIN.ScheduleID " +
                "inner join TICKET on TRAIN.TrainID = TICKET.TrainID inner join PEOPLE on TICKET.CustomerUN = PEOPLE.Username " +
                "where Username = '" + UserName + "'";
            return db.GetRecord(query, null);
        }
        public DataTable GetAllTicket()
        {
            string query = "select * from TICKET where CustomerUN = '" + GUI.userName + "'";
            return db.GetRecord(query, null);
        }
    }
}
