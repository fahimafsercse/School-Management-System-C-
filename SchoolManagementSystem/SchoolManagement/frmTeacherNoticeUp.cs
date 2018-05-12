using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Data;
using System.Windows.Forms;

namespace SchoolManagement
{
    public partial class frmTeacherNoticeUp : Form
    {
        TeacherDataAccess teacherDataAccess;
        NoticeDataAccess notice; 
        public frmTeacherNoticeUp()
        {
            teacherDataAccess = new TeacherDataAccess();
            notice = new NoticeDataAccess();
            InitializeComponent();
            textBox1.Text = "Student";
            textBox1.Enabled = false;
        }

        private void bttnTeacherSend_Click(object sender, EventArgs e)
        {
            if (tNoticeSubtxt.Text != "")
            {
                if (bttnTeacherSend.Text == "Update")
                {
                    string sub = tNoticeSubtxt.Text;
                    notice.DeleteNotice(sub);
                    bttnTeacherSend.Text = "Send";

                }
                DateTime thisDay = DateTime.Today;
                string dateOnly = thisDay.ToString("g");
                string noticeSub = tNoticeSubtxt.Text;
                string NoticeDescription = txtTDescription.Text;
                string sendTo = "Student";


                teacherDataAccess.SetTeacherNotice("Teacher", sendTo, dateOnly, "Teacher", noticeSub, NoticeDescription);
                dataGridView1.DataSource = teacherDataAccess.getNoticeList();
            }
            else
            {
                MessageBox.Show("Fill Rquired Box");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                tNoticeSubtxt.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtTDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bttnTeacherSend.Text = "Update";
                //new frmUpdateNoticeAdmin().Show();
            }
            else if (e.ColumnIndex == 1)
            {
                string noticeSub = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                notice.DeleteNotice(noticeSub);
                dataGridView1.Rows.RemoveAt(e.RowIndex);

            }
        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
        }
    }
}
