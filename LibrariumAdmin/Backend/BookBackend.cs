using Dapper;
using LibrariumAdmin.Models;

namespace LibrariumAdmin.Backend
{
    public static class BookBackend
    {
        public static List<BookModel> GetBooks() {
            using var connection = MySQLConnection.GetConnection();
            string query = "SELECT * FROM books;";
            var books = connection.Query<BookModel>(query).ToList();
            return books;
        }

        public static BookModel? GetBookById(int id)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "SELECT * FROM books WHERE BookID = @Id;";
            return connection.QueryFirstOrDefault<BookModel>(query, new { Id = id });
        }

        public static void AddBook(BookModel book)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "INSERT INTO books (Thumbnail, Title, Author, Publisher, ISBN, Status, Description) VALUES (@Thumbnail, @Title, @Author, @Publisher, @ISBN, 'Available', @Description);";
            connection.Execute(query, book);
        }

        public static void UpdateBook(BookModel book)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "UPDATE books SET Thumbnail = @Thumbnail, Title = @Title, Author = @Author, Publisher = @Publisher, ISBN = @ISBN, Description = @Description WHERE BookID = @BookID;";
            connection.Execute(query, book);
        }

        public static void DeleteBook(int id)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "DELETE FROM books WHERE BookID = @Id;";
            connection.Execute(query, new { Id = id });
        }

    }
}
