//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;

//namespace pbl
//{
//    internal class Class1
//    {
//        public static void Main()
//        {
//            read();
//        }
//        public static void connect()
//        {
//            string s;
//            SqlConnection conn;
//            s = @"Data Source=DESKTOP-DKTP37G\CSDL;User ID=train;Password=12345678";
//            conn = new SqlConnection(s);
//            conn.Open();
//            //read, write
//            conn.Close();
//        }
//        public static void read()
//        {
//            string s;
//            SqlConnection conn;
//            s = @"Data Source=DESKTOP-DKTP37G\CSDL;User ID=train;Password=12345678";
//            conn = new SqlConnection(s);
//            conn.Open();
//            //read, write

//            SqlCommand cmd;
//            SqlDataReader reader;
//            string sql = "select ID from PEOPLE";
//            cmd = new SqlCommand(sql, conn);
//            reader = cmd.ExecuteReader();

//            while (reader.Read())
//            {
//                Console.WriteLine(reader.GetValue(0));
//            }
//            reader.Close();
//            cmd.Dispose();
//            conn.Close();
//        }
//    }
//}
