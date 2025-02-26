using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    class DBHelper
    {
        private static string connectionString ="server=localhost;database=LibraryInfoManageDB;uid=root;pwd=null";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
