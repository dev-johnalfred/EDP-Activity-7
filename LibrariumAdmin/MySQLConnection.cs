using MySql.Data.MySqlClient;

namespace LibrariumAdmin
{
    public static class MySQLConnection
    {
        private static readonly string server = "localhost";
        private static readonly string database = "librarium";
        private static readonly string username = "root";
        private static readonly string password = "alfred";

        private static readonly string connectionString = $"Server={server};Database={database};Uid={username};Pwd={password};";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}