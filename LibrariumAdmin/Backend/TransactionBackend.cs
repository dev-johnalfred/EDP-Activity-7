using Dapper;
using LibrariumAdmin.Models;

namespace LibrariumAdmin.Backend
{
    public static class TransactionBackend
    {
        public static List<TransactionViewModel> GetTransactions()
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "SELECT * FROM transaction_view;";
            return connection.Query<TransactionViewModel>(query).ToList();
        }

        public static TransactionHeaderModel? GetTransactionHeaderById(int PatronId)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "SELECT * FROM transaction_header WHERE PatronID = @PatronID;";
            return connection.QueryFirstOrDefault<TransactionHeaderModel>(query, new { PatronId });
        }

        public static List<BookModel>? ViewTransactionBooks(int PatronID)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = @"
                SELECT b.*
                FROM transaction_header th
                JOIN transaction_detail td ON th.TransactionHeaderID = td.TransactionHeaderID
                JOIN books b ON td.BookID = b.BookID
                WHERE th.PatronID = @PatronID;
            ";
            return connection.Query<BookModel>(query, new { PatronID }).ToList();
        }

        public static void ConfirmTransaction(int PatronID, List<BookModel>? books)
        {
            using var connection = MySQLConnection.GetConnection();

            // Insert the new transaction header
            string query = "INSERT INTO transaction_header (PatronID) VALUES (@PatronID);";
            connection.Execute(query, new { PatronID });

            // Retrieve the latest transaction header
            query = "SELECT TransactionHeaderID FROM transaction_header WHERE PatronID = @PatronID ORDER BY TransactionHeaderID DESC LIMIT 1";
            TransactionHeaderModel? transactionHeader = connection.QueryFirstOrDefault<TransactionHeaderModel>(query, new { PatronID });

            if (transactionHeader != null && books != null && books.Any())
            {
                query = "INSERT INTO transaction_detail (TransactionHeaderID, BookID) VALUES (@TransactionHeaderID, @BookID);";

                foreach (var book in books)
                {
                    connection.Execute(query, new { transactionHeader.TransactionHeaderID, book.BookID });
                }
            }
        }
    }
}
