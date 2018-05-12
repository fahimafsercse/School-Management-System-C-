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
    public partial class frmAdminUpNotice : Form
    {
        StudentDataAccess studentDataAccess;
        AdminDataAccess adminDataAccess;
        TeacherDataAccess teacherDataAccess;
        NoticeDataAccess noticeDataAccess;
        public frmAdminUpNotice()
        {
            InitializeComponent();
            comboBox1.Items.Add("Teacher");
            comboBox1.Items.Add("Student");
            comboBox1.Items.Add("Both");
            StartPosition = FormStartPosition.CenterScreen;
            studentDataAccess = new StudentDataAccess();
            adminDataAccess = new AdminDataAccess();
            teacherDataAccess = new TeacherDataAccess();
            noticeDataAccess = new NoticeDataAccess();
            dataGridView1.DataSource = adminDataAccess.getNoticeList();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttnAdminSend_Click(object sender, EventArgs e)
        {
            if (adminNoticeSubtxt.Text != "")
            {
                if (bttnAdminSend.Text == "Update")
                {
                    string sub = adminNoticeSubtxt.Text;
                    adminDataAccess.DeleteNotice(sub);
                    bttnAdminSend.Text = "Send";

                }
                DateTime thisDay = DateTime.Today;
                string dateOnly = thisDay.ToString("g");
                string noticeSub = adminNoticeSubtxt.Text;
                string NoticeDescription = txtAdminDescription.Text;
                string sendTo = comboBox1.SelectedItem.ToString();
                adminDataAccess.SetAdminNotice("Admin", sendTo, dateOnly, "Admin", noticeSub, NoticeDescription);
                dataGridView1.DataSource = adminDataAccess.getNoticeList();


            }
            else
            {
                MessageBox.Show("Fill Rquired Box");
            }
        }

        private void buttonClearAdminMsg_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "";
            adminNoticeSubtxt.Text = "";
            txtAdminDescription.Text = ""; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                comboBox1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                adminNoticeSubtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtAdminDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                bttnAdminSend.Text = "Update";
                //new frmUpdateNoticeAdmin().Show();
            }
            else if(e.ColumnIndex == 1)
            {
                string noticeSub = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                noticeDataAccess.DeleteNotice(noticeSub);
                dataGridView1.Rows.RemoveAt(e.RowIndex);

            }


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmAdminStartup().Show();
        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
        }
    }
}
