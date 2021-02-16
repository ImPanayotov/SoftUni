using Microsoft.Data.SqlClient;
using System;

namespace _01.Initial_Setup
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=IMPANAYOTOV\\SQLEXPRESS; Integrated Security = true; Database = Softuni";
            var connection = new SqlConnection(connectionString);
            connection.Open();
            var query = new SqlCommand("SELECT COUNT(*) FROM Employees");
        }
    }
}
