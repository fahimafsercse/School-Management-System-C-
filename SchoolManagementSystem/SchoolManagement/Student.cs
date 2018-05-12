using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class Student
    {
        string studentID;
        string studentPass;

        public Student()
        {

        }
        public Student(string studentID, string studentPass)
        {
            this.studentID = studentID;
            this.studentPass = studentPass;
        }
        public string AdminID { get { return this.studentID; } }
        public string AdminPass { get { return this.studentPass; } }

    }
}
