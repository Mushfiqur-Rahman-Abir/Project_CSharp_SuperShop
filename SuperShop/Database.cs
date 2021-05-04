using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperShop
{
    class Database
    {
        public static SqlConnection ConnectDB()
        {
            string connstring = @"Server=DESKTOP-RTQVKPL;DataBase=SuperShop;Integrated Security=true";
            SqlConnection conn = new SqlConnection(connstring);
            return conn;
        }
    }
}
