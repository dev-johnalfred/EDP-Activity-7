using Dapper;
using LibrariumAdmin.Models;

namespace LibrariumAdmin.Backend
{
    public static class PatronBackend
    {
        public static List<PatronModel> GetPatrons()
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "SELECT * FROM patrons;";
            var patrons = connection.Query<PatronModel>(query).ToList();
            return patrons;
        }

        public static PatronModel? GetPatronById(int PatronId)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "SELECT * FROM patrons WHERE PatronID = @PatronID;";
            return connection.QueryFirstOrDefault<PatronModel>(query, new { PatronId });
        }

        public static void AddPatron(PatronModel patron)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "INSERT INTO patrons (Avatar, FirstName, LastName, Email, PhoneNumber) VALUES (@Avatar, @FirstName, @LastName, @Email, @PhoneNumber);";
            connection.Execute(query, patron);
        }

        public static void UpdatePatron(PatronModel patron)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "UPDATE patrons SET Avatar = @Avatar, FirstName = @FirstName, LastName = @LastName, Email = @Email, PhoneNumber = @PhoneNumber WHERE PatronID = @PatronID;";
            connection.Execute(query, patron);
        }

        public static void DeletePatron(int PatronId)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "DELETE FROM patrons WHERE PatronID = @PatronID;";
            connection.Execute(query, new { PatronId = PatronId });
        }

        public static PatronModel? FindPatronById(int patronId)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "SELECT * FROM patrons WHERE PatronID = @PatronID;";
            return connection.QueryFirstOrDefault<PatronModel>(query, new { PatronID = patronId });
        }

    }
}
