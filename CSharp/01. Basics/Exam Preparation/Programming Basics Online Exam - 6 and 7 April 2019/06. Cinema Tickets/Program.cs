using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string movieTitle = "";
            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;
            int capacity = 0;
            int currentStudent = 0;
            int currentStandard = 0;
            int currentKid = 0;



            while (input != "Finish")
            {
                input = Console.ReadLine();
                int student = 0;
                int standard = 0;
                int kid = 0;
                if (input == "Finish")
                {
                    break;
                }
                capacity = int.Parse(input);
                for (int i = 0; i < capacity; i++)
                {
                    string curentPosition = Console.ReadLine();
                    if (curentPosition == "standard")
                    {
                        standard++;
                    }
                    else if (curentPosition == "student")
                    {
                        student++;
                    }
                    else if (curentPosition == "kid")
                    {
                        kid++;
                    }
                    else if (curentPosition == "End")
                    {
                        break;
                    }
                }
                totalKid += kid;
                totalStandard += standard;
                totalStudent += student;
                Console.WriteLine($"{movieTitle} - {(1.0 * currentStudent + currentKid + currentStandard) / capacity * 100:f2}% full.");
            }
            Console.WriteLine($"Total tickets: {totalKid + totalStandard + totalStudent}");
            Console.WriteLine($"{1.0 * totalStudent / (totalKid + totalStandard + totalStudent) * 100:f2}% student tickets.");
            Console.WriteLine($"{1.0 * totalStandard / (totalKid + totalStandard + totalStudent) * 100:f2}% standard tickets.");
            Console.WriteLine($"{1.0 * totalKid / (totalKid + totalStandard + totalStudent) * 100:f2}% kids tickets.");
        }
    }
}
