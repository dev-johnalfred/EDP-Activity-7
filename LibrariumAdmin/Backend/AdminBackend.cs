using Dapper;
using LibrariumAdmin.Models;

namespace LibrariumAdmin.Backend
{
    public static class AdminBackend
    {
        public static AdminModel? ValidateAdminLogin(string username, string password)
        {
            using var connection = MySQLConnection.GetConnection();
            string query = "SELECT * FROM admin WHERE username = @Username AND password = @Password;";
            var user = connection.QueryFirstOrDefault<AdminModel>(query, new { Username = username, Password = password });
            return user;
        }
    }
}
