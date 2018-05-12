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
    public partial class frmStudentStartup : Form
    {
        StudentDataAccess studentDataAccess;
        AdminDataAccess admindataAccess;
        TeacherDataAccess teacherDataAccess;
        

        public string userName { get; private set; }

        public frmStudentStartup()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            studentDataAccess = new StudentDataAccess();
            admindataAccess = new AdminDataAccess();
            teacherDataAccess = new TeacherDataAccess();

            dataGridView1.DataSource = studentDataAccess.GetStudentNotice();
          

        }

        private void bttnProfile_Click(object sender, EventArgs e)
        {
           
            new studentProfile().Show();
            //this.Hide();

        }

        private void bttnGrades_Click(object sender, EventArgs e)
        {
            new frmGrades().Show();
            this.Hide();
        }

        private void bttnCourseTechInfo_Click(object sender, EventArgs e)
        {
            new frmCourseTechInfo().Show();
        }

        private void bttnBackFromStSTARTUP_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGetBook_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new SeeBooks().Show();
        }
    }
}
