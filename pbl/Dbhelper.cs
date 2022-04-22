using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl
{
    public class Dbhelper
    {

        private SqlConnection cnn;
        public Dbhelper(string s)
        {
            cnn = new SqlConnection(s);
        }
        public void ExecuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public DataTable GetRecordSV(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, cnn);
            cnn.Open();
            adapter.Fill(dt);
            cnn.Close();
            return dt;
        }

    }
}
