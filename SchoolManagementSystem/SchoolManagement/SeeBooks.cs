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
    public partial class SeeBooks : Form
    {
        public SeeBooks()
        {
            InitializeComponent();
        }

        private void SeeBooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDBDataSet1.Library' table. You can move, or remove it, as needed.
            this.libraryTableAdapter.Fill(this.smsDBDataSet1.Library);

        }

        private void userChange_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmLogin().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new frmStudentStartup().Show();
        }
    }
}
