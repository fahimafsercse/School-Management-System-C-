using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
namespace SchoolManagement.Data
{
    public class StudentDataAccess
    {

        public DataTable getStudentInfo(string accountId)
        {
            string query = "SELECT StudentName,StudentClass,StudentId,StudentContctNo,StudentEmail FROM Student Where StudentId = '"+accountId+"'";           
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }

        public  int submitRegStudent(string name, string id, string cls, string mail, string contact)
        {  
            string query = string.Format("INSERT INTO RegStudentSubmission(Id,Name, Class,ContactInfo, Email ) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", id,name,cls,contact,mail);
            return DataAccess.ExecuteQuery(query);
        }
        public DataTable getRegStudentList()
        {
            string query = "SELECT  * FROM RegStudentSubmission";
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
       
        public int DeleteStudentReg(string id)
        {
            string query = string.Format("DELETE FROM RegStudentSubmission WHERE Id='{0}'", id);
            return DataAccess.ExecuteQuery(query);
        }
        public int AddStudent(string id, string name, string cls, string con, string email)
        {
            string query = string.Format("INSERT INTO Student(StudentId,StudentName, StudentClass,StudentContctNo ,StudentEmail) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", id, name, cls,con, email);
            return DataAccess.ExecuteQuery(query);
        }
        public DataTable GetStudentNotice()
        {
            string txt = "Student";
            string txt1 = "Both";
            string query = "SELECT  * FROM Notice Where NoticeFor ='"+txt+ "'  OR NoticeFor= '" + txt1+"'";
            SqlDataAdapter report = new SqlDataAdapter(query, DataAccess.Connection);
            DataTable dt = new DataTable();
            report.Fill(dt);
            return dt;
        }
        public int DeleteStudent(string id)
        {
            string query = string.Format("DELETE FROM Student WHERE Id = '"+id+"'");
            return DataAccess.ExecuteQuery(query);
        }

    }
}
