using LibrarySystem.Models;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Services
{
    public static class AuthService
    {
        public static User ValidateUser(string username, string password)
        {
            string sql = @"SELECT UserID, Username, Role, PasswordHash 
                      FROM users WHERE Username = @username";
            var dt = DBHelper.ExecuteQuery(sql,
                new MySqlParameter("@username", username));

            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];
            string storedHash = row["PasswordHash"].ToString();

            if (!BCrypt.Net.BCrypt.Verify(password, storedHash)) return null;

            return new User(
                Convert.ToInt32(row["UserID"]),
                row["Username"].ToString(),
                row["Role"].ToString()
            );
        }
    }
}
