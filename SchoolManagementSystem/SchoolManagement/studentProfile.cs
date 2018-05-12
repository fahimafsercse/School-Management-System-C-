using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SchoolManagement.Data;
namespace SchoolManagement
{
    public partial class studentProfile : Form
    {
        StudentDataAccess studentDataAccess;
        AdminDataAccess admindataAccess;
        TeacherDataAccess teacherDataAccess;
        LoginHistoryDataAccess login;
        public static string userId;

        public studentProfile()
        {
            login = new LoginHistoryDataAccess();
           
            userId = login.getLastLogin();
            MessageBox.Show(userId+" buccho");
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            studentDataAccess = new StudentDataAccess();
            admindataAccess = new AdminDataAccess();
            teacherDataAccess = new TeacherDataAccess();
            initialMethod();
        }



        public void initialMethod()
        {
            
            DataTable  dt = new DataTable();
            dt = studentDataAccess.getStudentInfo(userId);
            dataGridViewProfile.DataSource = dt;


        }
    }
}
