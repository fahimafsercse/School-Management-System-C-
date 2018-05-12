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
    public partial class frmStudentReg : Form
    {
        StudentDataAccess studentDataAccess;
        AdminDataAccess admindataAccess;
        TeacherDataAccess teacherDataAccess;
        public frmStudentReg()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            studentDataAccess = new StudentDataAccess();
            admindataAccess = new AdminDataAccess();
            teacherDataAccess = new TeacherDataAccess();
            comboBoxRegSelect.Items.Add("Student");
            comboBoxRegSelect.Items.Add("Teacher");
        }

        private void SubmitStudentReg_Click(object sender, EventArgs e)
        {
            
            if (comboBoxRegSelect.SelectedItem.ToString() == "Student")
            {
                string name = n.Text;
                string id = i.Text;
                string cls = c.Text;
                string mail = m.Text;
                string contact = co.Text;

                labelStudentClass.Text = "Class Name";
                if (name != "" || id != "" || cls != "" || mail != "" || contact != "")
                {
                    if (studentDataAccess.submitRegStudent(name, id, cls, mail, contact) == 1)
                    {
                        MessageBox.Show("Registration Submitted.");
                    }
                    else
                    {
                        MessageBox.Show("regstudentError");
                    }
                }
                else
                {
                    MessageBox.Show("Data Required!");
                }
            }
            else if(comboBoxRegSelect.SelectedItem.ToString() == "Teacher")
            {
                string name = n.Text;
                string id = i.Text;
                string cls = c.Text;
                string mail = m.Text;
                string contact  = co.Text;
                
                if (name != "" || id != "" || cls != "" || mail != "" || contact != "")
                {
                    if (teacherDataAccess.submitRegTeacher(name, id, cls, mail, contact) == 1)
                    {
                        MessageBox.Show("Registration Submitted.");
                    }
                    else
                    {
                        MessageBox.Show("regstudentError");
                    }
                }
                else
                {
                    MessageBox.Show("Data Required!");
                }

            }
             
        }

        private void studentRegBackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //new frmLogin().Show();
        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
        }

        private void comboBoxRegSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegSelect.SelectedItem.ToString()=="Teacher")
            {
                labelStudentClass.Text = "Course Name";
            }
            else
            {
                labelStudentClass.Text = "Class Name";
            }
        }
    }
}
