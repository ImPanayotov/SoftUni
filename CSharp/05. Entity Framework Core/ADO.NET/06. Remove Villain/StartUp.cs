using Microsoft.Data.SqlClient;
using System;

namespace _06._Remove_Villain
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

                int value = int.Parse(Console.ReadLine());

                string evilNameQuery = @"SELECT Name FROM Villains WHERE Id = @villainId";
                using var sqlCmd = new SqlCommand(evilNameQuery, connection);
                sqlCmd.Parameters.AddWithValue("@villainId", value);
                var name = (string) sqlCmd.ExecuteScalar();

                if (name == null)
                {
                    Console.WriteLine("No such villain was found.");
                    return;
                }

                var deleteVillainMinionsQuery = @"DELETE FROM MinionsVillains WHERE VillainId = @villainId";

                using var deleteVillainMinionsCmd = new SqlCommand(deleteVillainMinionsQuery, connection);
                deleteVillainMinionsCmd.Parameters.AddWithValue("@villainId", value);
                var affectedRows = deleteVillainMinionsCmd.ExecuteNonQuery();


                var deleteVillainQuery = @"DELETE FROM Villains WHERE Id = @villainId";
                using var deleteVillainCmd = new SqlCommand(deleteVillainQuery, connection);
                deleteVillainCmd.Parameters.AddWithValue("@villainId", value);
                deleteVillainMinionsCmd.ExecuteNonQuery();


                Console.WriteLine($"{name} was deleted.");
                Console.WriteLine($"{affectedRows} minions were released.");
            }
        }
    }
}
