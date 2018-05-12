using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
   public  class Admin
    {
        string adminID;
        string adminPass;

        public Admin()
        {
        }
        public Admin(string adminID, string adminPass)
        {
            this.adminID = adminID;
            this.adminPass = adminPass;
        }
        public string AdminID { get { return this.adminID; } }
        public string AdminPass { get { return this.AdminPass; } }
    }
}
