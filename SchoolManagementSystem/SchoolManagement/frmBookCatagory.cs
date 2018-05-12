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
    public partial class frmBookCatagory : Form
    {
        LibraryDataAccess libraryDataAccess;
        public frmBookCatagory()
        {
            InitializeComponent();
            libraryDataAccess = new LibraryDataAccess();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string catId = textBox1.Text;
            string catName = textBox2.Text;

            if(libraryDataAccess.AddCatagory(catId, catName) == 1)
            {
                MessageBox.Show("Catagory Added");
            }

        }
    }
}
