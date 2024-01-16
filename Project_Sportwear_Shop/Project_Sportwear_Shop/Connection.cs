using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project_Sportwear_Shop
{
    class Connection
    {
        public static string constr;
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(constr);
        }
    }
}
