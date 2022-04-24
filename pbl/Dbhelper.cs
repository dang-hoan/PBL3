using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl
{
    public class DBHelper
    {
        private SqlConnection cnn;
        public DBHelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public int CountRecord(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            int count = (int)cmd.ExecuteScalar();
            cnn.Close();
            return count;
        }
        public int ExcuteDB(string query, SqlParameter p)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            if(p != null) cmd.Parameters.Add(p);
            cnn.Open();
            int result = cmd.ExecuteNonQuery();
            cnn.Close();
            return result;
        }
        public DataTable GetRecord(string query, SqlParameter p)
        {
            SqlDataAdapter ada = new SqlDataAdapter(query, cnn);
            DataTable dt = new DataTable();
            if (p != null) ada.UpdateCommand.Parameters.Add(p);
            cnn.Open();
            ada.Fill(dt);
            cnn.Close();
            return dt;
        }
    }
}
