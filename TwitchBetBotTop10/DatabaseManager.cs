using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace TwitchBetBotTop10
{
    public class DatabaseManager
    {
        private readonly string _connectionString;

        public DatabaseManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<User> GetAllUsers()
        {
            var query = "SELECT * FROM Viewers";

            var users = new List<User>();

            using (var connection = new MySqlConnection(_connectionString))
            using (var cmd = new MySqlCommand(query, connection))
            {
                connection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User {Id = reader.GetInt32("ID"), Name = reader.GetString("Name"), Coins = reader.GetInt32("Coins"), UserLevel = (UserRoles)reader.GetByte("UserLevel"), Password = reader.GetString("Password")});
                    }
                }
            }

            return users;
        }
    }
}
