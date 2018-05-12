using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SchoolManagement.Data
{
    public class TeacherDataAccess
    {
        public DataTable getRegTeacherList()
        {
            string query = "SELECT  * FROM RegTeacherSubmission";
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public int submitRegTeacher(string name, string id, string course, string mail, string contact)
        {
            string query = string.Format("INSERT INTO RegTeacherSubmission(Id,Name, Course,Contact, Email) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", id, name,course, contact, mail);
            return DataAccess.ExecuteQuery(query);
        }


        public int DeleteTeacherReg(string id)
        {
            string query = string.Format("DELETE FROM RegTeacherSubmission WHERE Id='{0}'", id);
            return DataAccess.ExecuteQuery(query);
        }

        public int AddTeacher(string id,string name ,string con,string email,string course)
        {
            string query = string.Format("INSERT INTO Teacher(TeacherId,TeacherName, TeacherContact,TeacherEmail ,TeacherCourse) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", id, name, con, email, course);
            return DataAccess.ExecuteQuery(query);
        }

        public int SetTeacherNotice(string id, string noticefor, string date, string from, string noticeSub, string noticeDesCription)
        {
            string query = string.Format("INSERT INTO Notice(Id,NoticeFor,NoticeDate, NoticeFrom,NoticeSubject,NoticeDes) VALUES('{0}', '{1}', '{2}', '{3}', '{4}','{5}')", id, noticefor, date, from, noticeSub, noticeDesCription);
            return DataAccess.ExecuteQuery(query);
        }







        public int DeleteTeacher(string id)
        {
            string query = string.Format("Delete FROM Teacher where TeacherId = '" + id + "'");
            return DataAccess.ExecuteQuery(query);
        }


        public DataTable getTeacherList()
        {
            string query = "SELECT  * FROM Teacher";
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public DataTable getNoticeList()
        {
            string txt = "Teacher";
            string query = "SELECT  * FROM Notice Where NoticeFrom = '" + txt + "'";
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
    }
}