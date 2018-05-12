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
    public partial class frmTeachersStartup : Form
    {
        LoginHistoryDataAccess login;
        public frmTeachersStartup()
        {
            login = new LoginHistoryDataAccess();
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            dataGridView1.DataSource = login.GetTeacherNotice();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
        }

        private void bttnAssignGrades_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmAssignGrades().Show();
        }

        private void bttnTeacherProfile_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmTeacherProfile().Show();
        }

        private void noticeButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmTeacherNoticeUp().Show();
        }
    }
}
