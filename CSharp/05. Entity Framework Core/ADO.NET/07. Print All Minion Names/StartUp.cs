using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Print_All_Minion_Names
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

                var minionsQuery = @"SELECT Name FROM Minions";

                SqlCommand sqlCommand = new SqlCommand(minionsQuery, connection);
                List<string> names = new List<string>();

                using (sqlCommand)
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        names.Add((string)reader["Name"]);
                    }

                    while (names.Count != 0)
                    {
                        Console.WriteLine(names[0]); ;
                        names.RemoveAt(0);

                        if (names.Count == 0)
                            break;

                        Console.WriteLine(names.Last());
                        names.RemoveAt(names.Count - 1);
                    }
                }
            }
        }
    }
}
