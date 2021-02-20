using Microsoft.Data.SqlClient;
using System;

namespace _04._Add_Minion
{
    class StartUp
    {
        const string SqlConnectionString = "Server=IMPANAYOTOV\\SQLEXPRESS; " +
                                              "Integrated Security = true; " +
                                              "Database = MinionsDB";
        static void Main(string[] args)
        {

            using (var connection = new SqlConnection(SqlConnectionString))
            {
                connection.Open();

                string[] minionInfo = Console.ReadLine().Split();

                string[] villainInfo = Console.ReadLine().Split();

                string minionName = minionInfo[1];
                int age = int.Parse(minionInfo[2]);
                string town = minionInfo[3];

                int? townId = GetTownId(connection, town);

                if (townId == null)
                {
                    string createTownQuery = @"INSERT INTO Towns (Name) VALUES (@townName)";
                    using var sqlCommand = new SqlCommand(createTownQuery, connection);
                    sqlCommand.Parameters.AddWithValue("@name", town);
                    sqlCommand.ExecuteNonQuery();

                    townId = GetTownId(connection, town);

                    Console.WriteLine($"Town {town} was added to the database.");
                }

                string villainName = villainInfo[1];
                int? villainId = GetVillainId(villainName, connection);

                if (villainId == null)
                {
                    string createVillain = @"INSERT INTO Villains (Name, EvilnessFactorId)  VALUES (@villainName, 4)";
                    using var sqlCommand = new SqlCommand(createVillain, connection);
                    sqlCommand.Parameters.AddWithValue("@villainName", villainName);
                    sqlCommand.ExecuteNonQuery();

                    villainId = GetVillainId(villainName, connection);

                    Console.WriteLine($"Villain {villainName} was added to the database.");
                }

                CreateMinion(connection, minionName, age, townId);

                var minionId = GetMinionId(connection, minionName);

                InsertMinionVillain(connection, villainId, minionId);

                Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
            }

        }

        private static void InsertMinionVillain(SqlConnection connection, int? villainId, int? minionId)
        {
            var insertIntoMinVil = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (@villainId, @minionId)";

            var sqlCommand = new SqlCommand(insertIntoMinVil, connection);
            sqlCommand.Parameters.AddWithValue("@villainId", minionId);
            sqlCommand.Parameters.AddWithValue("@minionId", villainId);
            sqlCommand.ExecuteNonQuery();
        }

        private static int? GetMinionId(SqlConnection connection, string minionName)
        {
            var minionIdQuery = @"SELECT Id FROM Minions WHERE Name = @Name";
            var sqlCommand = new SqlCommand(minionIdQuery, connection);
            sqlCommand.Parameters.AddWithValue("@name", minionName);
            var minionId = sqlCommand.ExecuteScalar();
            return (int?) minionId;
        }

        private static void CreateMinion(SqlConnection connection, string minionName, int age, int? townId)
        {
            string createMinion = @"INSERT INTO Minions (Name, Age, TownId) VALUES (@name, @age, @townId)"; // @nam error
            using var sqlCommand = new SqlCommand(createMinion, connection);
            sqlCommand.Parameters.AddWithValue("@name", minionName);
            sqlCommand.Parameters.AddWithValue("@age", age);
            sqlCommand.Parameters.AddWithValue("@townId", townId);
            sqlCommand.ExecuteNonQuery();
        }

        private static int? GetVillainId(string villainName, SqlConnection connection)
        {
            string query = @"SELECT Id FROM Villains WHERE Name = @Name";
            using var sqlCommand = new SqlCommand(query, connection);
            sqlCommand.Parameters.AddWithValue("@Name", villainName);
            var villainId = sqlCommand.ExecuteScalar();

            return (int?)villainId;
        }

        private static int? GetTownId(SqlConnection connection, string town)
        {
            string townIdQuery = @"SELECT Id FROM Towns WHERE Name = @townName";
            using var sqlCommand = new SqlCommand(townIdQuery, connection);
            sqlCommand.Parameters.AddWithValue("@townName", town);
            var townId = sqlCommand.ExecuteScalar();

            return (int?)townId;
        }
    }
}
