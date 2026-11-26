using System;
using LibrarySystem.Models;
using MySql.Data.MySqlClient;

namespace LibrarySystem.Services
{
    public static class AuthService
    {
        public static User ValidateUser(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
                return null;

            var users = DBHelper.ExecuteQuery("SELECT * FROM users WHERE Username = @username",
                new MySqlParameter("@username", username));
            if (users.Rows.Count != 1)
                return null;

            var row = users.Rows[0];
            string hash = users.Columns.Contains("PasswordHash") ? row["PasswordHash"].ToString() : "";
            bool valid;
            if (!string.IsNullOrEmpty(hash))
            {
                try
                {
                    valid = BCrypt.Net.BCrypt.Verify(password, hash);
                }
                catch (BCrypt.Net.SaltParseException)
                {
                    return null;
                }
            }
            else
            {
                valid = users.Columns.Contains("Password") && !row.IsNull("Password")
                    && string.Equals(password, row["Password"].ToString(), StringComparison.Ordinal);
            }

            return valid
                ? new User(Convert.ToInt32(row["UserID"]), row["Username"].ToString(), row["Role"].ToString())
                : null;
        }
    }
}
