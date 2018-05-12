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
    public partial class frmTeacherProfile : Form
    {
         
        LoginHistoryDataAccess login;
        public static string userId; 
        public frmTeacherProfile()
        {
            login = new LoginHistoryDataAccess();
            InitializeComponent();

            userId = login.getLastLogin();

            dataGridView1.DataSource = login.GetTeacherInfoById(userId);
            StartPosition = FormStartPosition.CenterScreen;


        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
        }
    }
}
