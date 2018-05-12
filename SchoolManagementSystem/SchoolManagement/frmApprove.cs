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
    public partial class frmApprove : Form
    {
        StudentDataAccess studentDataAccess;
        AdminDataAccess admindataAccess;
        TeacherDataAccess teacherDataAccess;
        public frmApprove()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            studentDataAccess = new StudentDataAccess();
            admindataAccess = new AdminDataAccess();
            teacherDataAccess = new TeacherDataAccess();
            comboBox1.Items.Add("Teacher");
            comboBox1.Items.Add("Student");
            MessageBox.Show("Test1");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           string  selectedItem = comboBox1.SelectedItem.ToString();
            if (selectedItem == "Student")
            {
                dataGridView1.DataSource =   studentDataAccess.getRegStudentList();
            }
            else
            {
                dataGridView1.DataSource = teacherDataAccess.getRegTeacherList();
            }
            
        }

        private void bttnBackFromAprove_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmAdminStartup().Show();

        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
        }

        private void dataGridViewApprove_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Test");
            MessageBox.Show(e.ColumnIndex.ToString());
            if (e.ColumnIndex == 0)
            {

                string selectedItem = comboBox1.SelectedItem.ToString();
                if (selectedItem == "Teacher")
                {
                    int selectedRow = e.RowIndex;

                    string id = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
                    string name = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
                    string con = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
                    string email = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();
                    string course = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();

                    if (teacherDataAccess.AddTeacher(id, name, con, email, course) == 1) { MessageBox.Show("Teacher added"); }
                    if (teacherDataAccess.DeleteTeacherReg(id) == 1)
                    {
                        MessageBox.Show("current column deleted");
                    }

                    dataGridView1.DataSource = teacherDataAccess.getRegTeacherList();

                }
                else if (selectedItem == "Student")
                {
                    int selectedRow = e.RowIndex;
                    string id = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
                    string name = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
                    string cls = dataGridView1.Rows[selectedRow].Cells[4].Value.ToString();
                    string con = dataGridView1.Rows[selectedRow].Cells[5].Value.ToString();
                    string email = dataGridView1.Rows[selectedRow].Cells[6].Value.ToString();
                    studentDataAccess.AddStudent(id, name, cls, con, email);
                    dataGridView1.DataSource = studentDataAccess.getRegStudentList();
                }

            }
            else if (e.ColumnIndex == 1)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();
                if (selectedItem == "Teacher")
                {

                    int selectedRow = e.RowIndex;
                    string id = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
                    if (teacherDataAccess.DeleteTeacherReg(id) == 1)
                    {
                        MessageBox.Show("Ignored");
                        dataGridView1.DataSource = teacherDataAccess.getRegTeacherList();
                    }
                    else
                    {
                        MessageBox.Show("hoilo na to teacher");
                    }
                }
                else
                {
                    int selectedRow = e.RowIndex;
                    string id = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
                    if (studentDataAccess.DeleteStudentReg(id) == 1)
                    {
                        MessageBox.Show("hoilo na to student");
                    }
                    dataGridView1.DataSource = studentDataAccess.getRegStudentList();
                }
            }

        }
    }
}

