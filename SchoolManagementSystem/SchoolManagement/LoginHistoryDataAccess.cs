using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace SchoolManagement
{
    public class LoginHistoryDataAccess
    {
        public int  setHistory(string text, string date)
        {
            string query = string.Format("UPDATE UserLoginHistory Set Id = '"+text+"' ,LoginTime = '"+date+"'");
            return DataAccess.ExecuteQuery(query);
        }


        public string getLastLogin()
        {
            string query = string.Format("Select Id FROM UserLoginHistory");
            SqlDataReader reader = DataAccess.GetData(query);
            string s = "";
            while(reader.Read())
            {
                s = reader["Id"].ToString();
            }
            return s;
        }

        public DataTable GetTeacherInfoById(string id)
        {
            List<string> teach = new List<string>();
            string query = string.Format("Select * from Teacher where TeacherId  = '" + id + "'");
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            SqlDataReader reader = DataAccess.GetData(query);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public DataTable GetTeacherNotice()
        {
            string txt = "Teacher";
            string txt1 = "Both";
            string query = "SELECT * FROM  Notice  Where NoticeFor = '"+ txt +"' OR NoticeFor = '"+txt1+"' ";
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            SqlDataReader reader = DataAccess.GetData(query);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }







    }
}
