using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class CourseDataAccess
    {
        public int  SetGrade(string  id, string course , string grade)
        {
            if (course == "Bangla")
            {
                string query = string.Format("UPDATE Course SET GradeBangla = '"+grade+"' WHERE StudentId =  '"+id+"'");
                return DataAccess.ExecuteQuery(query);
            }
            else if(course == "English")
            {
                string query = string.Format("UPDATE Course SET GradeEnglish = '" + grade + "' WHERE StudentId =  '" + id + "'");
                return DataAccess.ExecuteQuery(query);
            }
            else if (course == "Math")
            {
                string query = string.Format("UPDATE Course SET GradeMath = '" + grade + "'' WHERE StudentId =  '" + id + "' ");
                return DataAccess.ExecuteQuery(query);
            }
            return -1;
            
        }
        public List<string> getGrades(string id)
        {
            string query = string.Format("SELECT Student.StudentName ,Course.GradeBangla, Course.GradeEnglish, Course.GradeMath  FROM Course INNER JOIN Student on Course.StudentId = '" + id + "'");
            DataTable dt = new DataTable();
            SqlDataReader reader = DataAccess.GetData(query);
            reader.Read();
            List<string> gradeList = new List<string>();
            if (reader.HasRows)
            {
                gradeList.Add(reader["StudentName"].ToString());
                gradeList.Add(reader["GradeBangla"].ToString());
                gradeList.Add(reader["GradeEnglish"].ToString());
                gradeList.Add(reader["GradeMath"].ToString());
            }
            return gradeList;
           
        }
        public List<string > getTeacherBySub(string sub)
        {
            List<string> teach = new List<string>();
            System.Windows.Forms.MessageBox.Show(sub);
            string query =  string.Format("Select  * from Teacher where TeacherCourse = '" + sub+"' ");

            SqlDataReader reader = DataAccess.GetData(query);
            System.Windows.Forms.MessageBox.Show("Test2");
            if(reader.HasRows)
            {
               // System.Windows.Forms.MessageBox.Show(reader["TeacherName"].ToString());
                teach.Add(reader["TeacherName"].ToString());
                teach.Add(reader["TeacherEmail"].ToString());
                System.Windows.Forms.MessageBox.Show("Test4");
            }
           /* else
            {
                System.Windows.Forms.MessageBox.Show("NO data");
            }*/
            return teach;

        }




    }
}






    