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
        public static MySqlConnection GetConnection()
        {
            string connectionString = Environment.GetEnvironmentVariable("LIBRARYSYSTEM_CONNECTION_STRING");
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("请先配置 LIBRARYSYSTEM_CONNECTION_STRING。");
            return new MySqlConnection(connectionString);
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

