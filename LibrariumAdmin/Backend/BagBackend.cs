using Dapper;
using LibrariumAdmin.Models;

namespace LibrariumAdmin.Backend
{
    public static class BagBackend
    {
        public static void AddNewBag(int PatronID)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "INSERT INTO bag_header (PatronID) VALUES (@PatronID);";
            connection.Execute(query, new { PatronID });
        }

        public static void AddBookToBag(int PatronID, int BookId)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "INSERT INTO bag_detail (BagHeaderID, BookID) VALUES ((SELECT BagHeaderID FROM bag_header WHERE PatronID = @PatronID), @BookId);";
            connection.Execute(query, new { PatronID, BookId });
        }

        public static List<BookModel>? CheckBooksInBag(int PatronID)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = @"
                SELECT b.*
                FROM bag_header bh
                JOIN bag_detail bd ON bh.BagHeaderID = bd.BagHeaderID
                JOIN books b ON bd.BookID = b.BookID
                WHERE bh.PatronID = @PatronID;
            ";
            return connection.Query<BookModel>(query, new { PatronID }).ToList();
        }

        public static void ClearBag(int PatronID)
        {
            using var connection = MySQLConnection.GetConnection();
            string deleteDetailQuery = @"
        DELETE bd
        FROM bag_header bh
        JOIN bag_detail bd ON bh.BagHeaderID = bd.BagHeaderID
        WHERE bh.PatronID = @PatronID;
    ";
            connection.Execute(deleteDetailQuery, new { PatronID });

            string deleteHeaderQuery = @"
        DELETE
        FROM bag_header
        WHERE PatronID = @PatronID;
    ";
            connection.Execute(deleteHeaderQuery, new { PatronID });
        }

    }
}
