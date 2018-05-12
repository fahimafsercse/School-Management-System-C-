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
    public partial class frmAssignGrades : Form
    {
        CourseDataAccess courseDataAccess;
        public frmAssignGrades()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            courseDataAccess = new CourseDataAccess();
            comboBox2.Items.Add("Bangla");
            comboBox2.Items.Add("English");
            comboBox2.Items.Add("Math");

        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin();
        }

        private void buttonGradeSubmit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("baicha asi");


           /* string courseName = comboBox2.SelectedItem.ToString();
            string id = textBox1.Text;
            string grade = textBox2.Text;*/

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(comboBox2.SelectedItem.ToString()))
            {
                MessageBox.Show("Data Required");
            }
            else
            {
                string courseName = comboBox2.SelectedItem.ToString();
                string id = textBox1.Text;
                string grade = textBox2.Text;
                if (courseDataAccess.SetGrade(id, courseName, grade) == 1)
                {
                    MessageBox.Show("Grade Assigned");
                }
                
            }

            //ADD  IN DB  SO THAT A STUDENT CAN SEE HIS GRADE ;

        }
    }
}
