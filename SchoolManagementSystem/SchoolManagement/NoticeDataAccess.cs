using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class NoticeDataAccess
    {
        public int DeleteNotice(string noticeSub)
        {
            string query = string.Format("Delete FROM Notice  where NoticeSubject = '" +noticeSub + "'");
            return DataAccess.ExecuteQuery(query);
        }

    }
}
