using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SchoolManagement.Data
{
    public class AccountDataAccess
    {
        
        public string getUserValidity(string userName, string password)
        {
            System.Windows.Forms.MessageBox.Show(userName+ password);
            string query = "SELECT AccountId,Password,UserCatagory FROM Account Where AccountId = '" + userName+"' AND Password = '"+password+"'";
            SqlDataReader reader = DataAccess.GetData(query);
            while (reader.Read())
            {
                string cat = reader["UserCatagory"].ToString();
                return cat;
            }
            return "INVALID";
        }

    }
}
