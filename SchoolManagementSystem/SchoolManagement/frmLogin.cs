using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SchoolManagement.Data;
using SchoolManagement.Data;


namespace SchoolManagement
{
    public partial class frmLogin : Form
    {
            public  string password;

        AccountDataAccess accountDataAccess;
        LoginHistoryDataAccess loginHistoryDataAccess;

        public frmLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            accountDataAccess = new AccountDataAccess();
            loginHistoryDataAccess = new LoginHistoryDataAccess();
        }
        public string username { get; private set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
             username = txtUserName.Text;
             password = txtPassword.Text;
            
            string getUser = accountDataAccess.getUserValidity(username, password);
            MessageBox.Show(getUser);
            if(getUser == "UT3")
            {
                DateTime thisDay = DateTime.Today;
                string date = thisDay.ToString("g");
                loginHistoryDataAccess.setHistory(txtUserName.Text, date);


                new frmStudentStartup().Show();

               

            }
            else if (getUser == "UT2")
            {
                DateTime thisDay = DateTime.Today;
                string date = thisDay.ToString("g");
                loginHistoryDataAccess.setHistory(txtUserName.Text, date);
                new frmTeachersStartup().Show();
            }
            else if (getUser == "UT1")
            {
                DateTime thisDay = DateTime.Today;
                string date = thisDay.ToString("g");
                loginHistoryDataAccess.setHistory(txtUserName.Text, date);
                new frmAdminStartup().Show();
            }
            else
            {
                MessageBox.Show("Invalid Account");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            string date = thisDay.ToString("g");
            loginHistoryDataAccess.setHistory(txtUserName.Text, date);
            new frmStudentReg().Show();
        }
    }
}
