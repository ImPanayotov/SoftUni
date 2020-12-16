using System;

namespace _08.Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double socialPrice = salary * 0.35;
            double excellentPrice = grade * 25;

            if (grade <= 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (grade > 4.50 && grade < 5.50)
            {
                if (income < salary)
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialPrice)} BGN");
                }
                else
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
            }
            else if (grade >= 5.50)
            {
                if (income < salary)
                {
                    if (socialPrice > excellentPrice)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialPrice)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentPrice)} BGN");
                    }
                }
                else
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentPrice)} BGN");
                }

            }
        }
    }
}
