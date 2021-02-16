using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());
            double highestBonus = 0.0;
            double highestBonusAttendances = 0.0;

            for (int i = 0; i < studentsCount; i++)
            {
               double attendances = double.Parse(Console.ReadLine());
               double totalBonus = attendances / lecturesCount * (5 + initialBonus);
                if (totalBonus > highestBonus)
                {
                    highestBonus = totalBonus;
                    highestBonusAttendances = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(highestBonus)}.");
            Console.WriteLine($"The student has attended {highestBonusAttendances} lectures.");
        }
    }
}