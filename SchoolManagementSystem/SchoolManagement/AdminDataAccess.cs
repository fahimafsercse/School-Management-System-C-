using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SchoolManagement.Data
{
    class AdminDataAccess
    {
        public DataTable getTeacherList()
        {
            string query = "SELECT  * FROM Teacher";
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public DataTable getStudentList()
        {
            string query = "SELECT  * FROM Student";
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public int SetAdminNotice(string id,string noticefor,string date,string  from,string noticeSub,string noticeDesCription)
        {
            string query = string.Format("INSERT INTO Notice(Id,NoticeFor,NoticeDate, NoticeFrom,NoticeSubject,NoticeDes) VALUES('{0}', '{1}', '{2}', '{3}', '{4}','{5}')", id,noticefor,date,from,noticeSub, noticeDesCription);
            return DataAccess.ExecuteQuery(query);
        }
        public DataTable getNoticeList()
        {
            string txt = "Admin";
            string query = "SELECT  * FROM Notice Where NoticeFrom = '"+txt+"'";
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }

        public int DeleteNotice(string subject)
        {
            string query = string.Format("Delete from Notice Where NoticeSubject = '"+subject+"'");
            return DataAccess.ExecuteQuery(query);

        }
        

    }
}
