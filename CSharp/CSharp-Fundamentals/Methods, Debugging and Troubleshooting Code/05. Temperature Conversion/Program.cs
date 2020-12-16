using System;

namespace _05._Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = double.Parse(Console.ReadLine());
            var celsius = FahrenheitTocelsius(fahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }

        static double FahrenheitTocelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}
