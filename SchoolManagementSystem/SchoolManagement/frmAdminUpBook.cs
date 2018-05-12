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
    public partial class frmAdminUpBook : Form
    {
        List<string> bookNames;
        LibraryDataAccess libraryDataAccess;
        public frmAdminUpBook()
        {
            InitializeComponent();

            libraryDataAccess = new LibraryDataAccess();
            bookNames = new List<string>();
            AutoCompleteMethod(txtNameSearch);
            bookNames = libraryDataAccess.GetCatagoryNames();
            foreach (string it in bookNames)
            {
                comboCAT.Items.Add(it);
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            string bookName = textNAME.Text;
            string bookID = textID.Text;
            string bookCAT = comboCAT.SelectedItem.ToString();
            string bookWRT = textWR.Text;
            string booklINK = textLINK.Text;


            if(libraryDataAccess.AddBook(bookID,bookName, bookCAT,bookWRT, booklINK)==1)
            {
                MessageBox.Show("Book Added to the Library!");
            }

        }

        private void frmAdminUpBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smsDBDataSet.Library' table. You can move, or remove it, as needed.
            this.libraryTableAdapter.Fill(this.smsDBDataSet.Library);

        }

      




        private void AutoCompleteMethod(TextBox txtBox)
        {

            txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            List<string> bookNameList = new List<string>();
            bookNameList =libraryDataAccess.GetBookNames();
            foreach (string it in bookNameList)
            {
                col.Add(it);
            }
            txtNameSearch.AutoCompleteCustomSource = col;
        }

        private void txtNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            int rowIn = -1;
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                string searchValue = txtNameSearch.Text;

                bool found = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString().Equals(searchValue))
                    {
                        rowIn = row.Index;
                        dataGridView1.Rows[rowIn].Selected = true;
                        found = true;
                        break;
                    }
                }
                if (found == false)
                {
                    MessageBox.Show("Book  Unavailable");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmBookCatagory().Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}
