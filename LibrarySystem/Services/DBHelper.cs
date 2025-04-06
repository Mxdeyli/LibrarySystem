using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    class DBHelper
    {
        private static MySqlConnection myConnection;
        private static string connectionString = "server=127.0.0.1;uid=root;pwd=123456;database=LibraryInfoManageDB";
        public static MySqlConnection GetConnection()
        {
            myConnection = new MySqlConnection(connectionString);
            //return new MySqlConnection(connectionString);
            //myConnection.Open();
            return myConnection;
            //return new MySql.Data.MySqlClient.MySqlConnection(connectionString);
        }
        public static DataTable ExecuteQuery(string sql, params MySqlParameter[] parameters) //执行查询操作
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public static int ExecuteNonQuery(string sql, params MySqlParameter[] parameters) //执行非查询操作
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                using (var cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddRange(parameters);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

