using System;

namespace _01.SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int totalPerHour = firstEmployee + secondEmployee + thirdEmployee;
            int counter = 0;
            while (studentsCount > 0)
            {
                counter++;
                if (counter % 4 == 0)
                {
                    continue;
                }
                else
                {
                    studentsCount -= totalPerHour;
                }
            }
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
