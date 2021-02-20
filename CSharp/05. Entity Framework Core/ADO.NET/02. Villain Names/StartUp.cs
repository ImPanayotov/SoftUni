using Microsoft.Data.SqlClient;
using System;

namespace _02._Villain_Names
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

                string query = @"SELECT [Name], COUNT(mv.MinionId)
	                                FROM Villains AS v
	                                JOIN MinionsVillains AS mv ON v.Id = mv.VillainId
	                                GROUP BY v.Id, v.Name";

                using (var command = new SqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            var name = reader[0];
                            var count = reader[1];

                            Console.WriteLine($"{name} - {count}");
                        }
                    }
                }
            }
        }
    }
}
