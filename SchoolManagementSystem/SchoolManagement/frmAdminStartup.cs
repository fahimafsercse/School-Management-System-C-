using SchoolManagement.Data;
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
    public partial class frmAdminStartup : Form
    {
        StudentDataAccess studentDataAccess;
        AdminDataAccess admindataAccess;
        TeacherDataAccess teacherDataAccess;
        LoginHistoryDataAccess login;
        public static string currentUser;
        public frmAdminStartup()
        {
            login = new LoginHistoryDataAccess();
            currentUser = login.getLastLogin();
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            comboBox1.Items.Add("Teacher");
            comboBox1.Items.Add("Student");

            studentDataAccess = new StudentDataAccess();
            admindataAccess = new AdminDataAccess();
            teacherDataAccess = new TeacherDataAccess();

        }

        private void bttnApprove_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmApprove().Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            if (selectedItem == "Student")
            {
                dataGridView1.DataSource = admindataAccess.getStudentList();
            }
            else
            {
                dataGridView1.DataSource = admindataAccess.getTeacherList();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
        }

        private void bttnAdminSend_Click(object sender, EventArgs e)
        {
            
        }

        private void bttnAdminNotice_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmAdminUpNotice().Show();
        }

        private void bttnAdminBookUP_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmAdminUpBook().Show();
        }
    }
}
