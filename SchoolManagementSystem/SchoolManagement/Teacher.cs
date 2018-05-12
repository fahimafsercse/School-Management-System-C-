using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Teacher
    {
       string teacherID;
       string teacherPass;


        public Teacher()
        {

        }
        public Teacher(string teacherId, string teacherPass)
        {
            this.teacherID = teacherId;
            this.teacherPass = teacherPass;
        }
        public string TeacherId { get { return this.teacherID; } }
        public string TeacherPass { get { return this.TeacherPass; } }


    }
}
