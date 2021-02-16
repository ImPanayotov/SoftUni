using System;

namespace _08._Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            int age = 27;
            char gender = 'f';
            decimal personalID = 8306112507;
            decimal employeeNumber = 27563571;

            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalID}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");
        }
    }
}
