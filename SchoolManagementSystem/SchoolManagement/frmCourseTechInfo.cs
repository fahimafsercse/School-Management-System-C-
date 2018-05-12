using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class frmCourseTechInfo : Form
    {
        //Tea teacherDataAccess;
        CourseDataAccess courseDataAcces;
        List<string> tc;
        LoginHistoryDataAccess login;
        

        public frmCourseTechInfo()
        {
            InitializeComponent();
            tc = new List<string>();

            courseDataAcces = new CourseDataAccess();
            login = new LoginHistoryDataAccess();

            tc = courseDataAcces.getTeacherBySub("Bangla");
            textBoxBNG.Text = tc[0];
            textBoxBNGTechEm.Text = tc[1];

            tc = courseDataAcces.getTeacherBySub("English");
            textBoxENG.Text = tc[0];
            textBoxENGTechEm.Text = tc[1];

            tc = courseDataAcces.getTeacherBySub("Math");
            textBoxMATH.Text = tc[0];
            textBoxMATHTechEm.Text = tc[1];
        }
        // mail 
        private void txtBanglaSend_Click(object sender, EventArgs e)
        {

        }

        private void txtEngSend_Click(object sender, EventArgs e)
        {

        }

        private void txtMathSend_Click(object sender, EventArgs e)
        {

        }

        private void txtSciSend_Click(object sender, EventArgs e)
        {

        }

        private void bttnBackFromCourseTechInfo_Click(object sender, EventArgs e)
        {
            new frmStudentStartup().Show();
            this.Hide();

        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
