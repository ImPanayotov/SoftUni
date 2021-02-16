using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int totalPerHour = firstEmployee + secondEmployee + thirdEmployee;
            int counter = 0;
            while (peopleCount > 0)
            {
                counter++;
                if (counter % 4 == 0)
                {
                    continue;
                }
                else
                {
                    peopleCount -= totalPerHour;
                }
            }
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
