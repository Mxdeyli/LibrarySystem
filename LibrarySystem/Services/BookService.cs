using System.Data;
using MySql.Data.MySqlClient;

namespace LibrarySystem.Services
{
    internal static class BookService
    {
        public static DataTable Search(string keyword)
        {
            const string sql = @"SELECT BookID, ISBN, Title, Author, Stock
                FROM books
                WHERE LOCATE(@keyword, Title) > 0 OR LOCATE(@keyword, ISBN) > 0
                    OR LOCATE(@keyword, Author) > 0
                ORDER BY Title, BookID";
            return DBHelper.ExecuteQuery(sql, new MySqlParameter("@keyword", keyword));
        }

        public static bool ChangeLoan(int userId, int bookId, bool borrowing)
        {
            using (var connection = DBHelper.GetConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                using (var command = new MySqlCommand("", connection, transaction))
                {
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@bookId", bookId);
                    // Take the same book lock before changing loans or stock in either direction.
                    command.CommandText = "SELECT Stock FROM books WHERE BookID = @bookId FOR UPDATE";
                    var stock = command.ExecuteScalar();
                    if (stock == null || (borrowing && System.Convert.ToInt32(stock) <= 0))
                        return false;

                    command.CommandText = borrowing
                        ? "INSERT INTO bookloans (UserID, BookID) VALUES (@userId, @bookId)"
                        : "DELETE FROM bookloans WHERE UserID = @userId AND BookID = @bookId ORDER BY LoanID LIMIT 1";
                    if (command.ExecuteNonQuery() != 1)
                        return false;

                    command.CommandText = borrowing
                        ? "UPDATE books SET Stock = Stock - 1 WHERE BookID = @bookId"
                        : "UPDATE books SET Stock = Stock + 1 WHERE BookID = @bookId";
                    if (command.ExecuteNonQuery() != 1)
                        return false;

                    transaction.Commit();
                    return true;
                }
            }
        }
    }
}
