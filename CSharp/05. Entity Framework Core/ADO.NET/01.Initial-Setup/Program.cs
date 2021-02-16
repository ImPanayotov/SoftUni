using Microsoft.Data.SqlClient;
using System;

namespace _01.Initial_Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=IMPANAYOTOV\\SQLEXPRESS; Integrated Security = true; Database = SoftUni";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string queryStr = "UPDATE Employees SET Salary += 0.12";
                SqlCommand sqlCommand = new SqlCommand(queryStr, connection);

                var rowsAffected = sqlCommand.ExecuteNonQuery();

                Console.WriteLine(rowsAffected);
            }

            //SqlConnection dbCon = new SqlConnection("Server=IMPANAYOTOV\\SQLEXPRESS; Integrated Security = true; Database = SoftUni");
            //dbCon.Open();
            //using (dbCon)
            //{
            //    SqlCommand command = new SqlCommand(
            //      "SELECT COUNT(*) FROM Employees", dbCon);
            //    int employeesCount = (int)command.ExecuteScalar();
            //    Console.WriteLine("Employees count: {0} ", employeesCount);
            //}


        }
    }
}
