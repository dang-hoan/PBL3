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
                    string query2 = "select Position from POSITION inner join PEOPLE on POSITION.PositionID = PEOPLE.PositionID" +
                        "inner join LOGIN on PEOPLE.Username = LOGIN.Username";
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
    }
}
