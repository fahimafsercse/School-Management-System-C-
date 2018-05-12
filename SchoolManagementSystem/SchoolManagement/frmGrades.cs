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
    public partial class frmGrades : Form
    {
        CourseDataAccess courseDataAcces;
        LoginHistoryDataAccess login;
        public static string userId ;
        List<string> getGrades;
        public frmGrades()
        {
            login = new LoginHistoryDataAccess();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            courseDataAcces = new CourseDataAccess();
            getGrades = new List<string>();
            userId = login.getLastLogin();
            getGrades = courseDataAcces.getGrades(userId);
            textBoxBangla.Text = getGrades[1];
            textBoxEnglish.Text = getGrades[2];
            textBoxMath.Text = getGrades[3];
        }

        private void bttnBackfromGrades_Click(object sender, EventArgs e)
        {
            new frmStudentStartup().Show();
            this.Hide();
        }
    }
}
