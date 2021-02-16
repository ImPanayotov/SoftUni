using System;
using System.Security.Cryptography.X509Certificates;

namespace _01._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string parameter = Console.ReadLine();

            if (dataType == "int")
            {
                DataType(int.Parse(parameter));
            }
            else if (dataType == "real")
            {
                DataType(double.Parse(parameter));
            }
            else if (dataType == "string")
            {
                DataType(parameter);
            }
        }
        public static void DataType(int integer)
        {
            int result = integer * 2;
            Console.WriteLine(result);
        }
        public static void DataType(double real)
        {
            double result = real * 1.5;
            Console.WriteLine($"{result:f2}");
        }
        public static void DataType(string str)
        {
            Console.WriteLine($"${str}$");
        }
    }
}
