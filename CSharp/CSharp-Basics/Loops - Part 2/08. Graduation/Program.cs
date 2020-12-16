using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int counter = 0;
            double sum = 0;
            while (counter < 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4)
                {
                    sum = sum + grade;
                    counter++;
                }
            }
            double lastGrade = sum / 12;
            if (lastGrade >= 4.00)
            {
                Console.WriteLine($"{name} graduated. Average grade: {lastGrade:F2}");
            }
        }
    }
}
