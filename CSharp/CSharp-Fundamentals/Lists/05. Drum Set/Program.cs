using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal savings = decimal.Parse(Console.ReadLine());

            List<int> drumSetOriginal = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> drumSet = new List<int>(drumSetOriginal);

            int price = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Hit it again, Gabsy!")
                {
                    break;

                }

                int power = int.Parse(input);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= power;

                    if (drumSet[i] <= 0)
                    {
                        price = drumSetOriginal[i] * 3;

                        if (savings >= price)
                        {
                            drumSet[i] = drumSetOriginal[i];
                            savings -= price;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            drumSetOriginal.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            foreach (var item in drumSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
