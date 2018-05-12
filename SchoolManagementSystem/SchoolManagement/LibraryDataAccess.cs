using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class LibraryDataAccess
    {
        public List<string> GetBookNames()
        {
            string query = "SELECT * FROM Library";
            SqlDataReader reader = DataAccess.GetData(query);
            List<string> bookName = new List<string>();
            while (reader.Read())
            {
                bookName.Add(reader["Name"].ToString());
            }
            return bookName;

        }
        public List<string> GetCatagoryNames()
        {
            string query = "SELECT * FROM BookCatagory";
            SqlDataReader reader = DataAccess.GetData(query);
            List<string> bookName = new List<string>();
            while (reader.Read())
            {
                bookName.Add(reader["CatagoryName"].ToString());
            }
            return bookName;

        }
        public int AddBook(string name, string id, string cat, string wrt, string lnk)
        {
            string query = string.Format("INSERT INTO Library(Id,Name,Catagory,Writer ,Link) VALUES('{0}', '{1}', '{2}', '{3}','{4}')",id,name,cat, wrt, lnk);
            return DataAccess.ExecuteQuery(query);
        }

        public int AddCatagory(string id,string name)
        {
            string query = string.Format("INSERT INTO BookCatagory(Id,CatagoryName) VALUES('{0}', '{1}')", id, name);
            return DataAccess.ExecuteQuery(query);

        }
    }
}
