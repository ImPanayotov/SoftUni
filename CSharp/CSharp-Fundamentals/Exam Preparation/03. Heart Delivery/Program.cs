using System;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] neighborhood = Console.ReadLine().Split("@").Select(double.Parse).ToArray();
            //int index = 0;
            //int counter = 0;


            //while (true)
            //{

            //    string command = Console.ReadLine();
            //    if (command == "Love!")
            //    {
            //        if (neighborhood.Sum() == 0)
            //        {
            //            Console.WriteLine("Mission was successful.");
            //        }
            //        else
            //        {
            //            int diffFromZero = 0;
            //            Console.WriteLine($"Cupid's last position was {index}.");
            //            for (int i = 0; i < neighborhood.Length; i++)
            //            {
            //                if (neighborhood[i] != 0)
            //                {
            //                    diffFromZero++;
            //                }
            //            }
            //            Console.WriteLine($"Cupid has failed {diffFromZero} places.");
            //        }
            //        break;
            //    }
            //    string[] array = command.Split();
            //    int jump = int.Parse(array[1]);

            //    if (index + jump >= neighborhood.Length)
            //    {
            //        if (neighborhood[0] != 0)
            //        {
            //            neighborhood[0] -= 2;
            //            if (neighborhood[0] == 0)
            //            {
            //                counter++;
            //                Console.WriteLine($"Place {neighborhood[0]} has Valentine's day.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Place {neighborhood[0]} already had Valentine's day.");
            //        }
            //        index = 0;
            //    }
            //    else
            //    {
            //        index += jump;
            //        if (neighborhood[index] != 0)
            //        {
            //            neighborhood[index] -= 2;
            //            if (neighborhood[index] == 0)
            //            {
            //                counter++;
            //                Console.WriteLine($"Place {index} has Valentine's day.");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Place {index} already had Valentine's day.");
            //        }
            //    }
            //}
            var evenIntegers = Console.ReadLine().Split('@').Select(int.Parse).ToList();
            var decreasedByTwo = 2;
            var input = "";
            var length = 0;
            var takeValue = 0;
            var saveLastIndex = 0;
            var counterSuccess = 0;
            var decrease = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                var command = input.Split();
                length = int.Parse(command[1]) + length;
                if (evenIntegers.Count <= length)
                {
                    length = 0;
                    var take = evenIntegers.GetRange(length, 1);
                    takeValue = take[0];
                    saveLastIndex = length;
                }
                else
                {
                    var take = evenIntegers.GetRange(length, 1);
                    takeValue = take[0];
                    saveLastIndex = length;
                }
                if (takeValue == 0)
                {
                    Console.WriteLine($"Place {saveLastIndex} already had Valentine's day.");
                    continue;
                }
                decrease = takeValue - decreasedByTwo;
                evenIntegers.RemoveAt(saveLastIndex);
                evenIntegers.Insert(saveLastIndex, decrease);
                if (decrease == 0)
                {
                    counterSuccess++;
                    Console.WriteLine($"Place {saveLastIndex} has Valentine's day.");
                }
            }
            Console.WriteLine($"Cupid's last position was {saveLastIndex}.");
            if (counterSuccess == evenIntegers.Count)
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {evenIntegers.Count - counterSuccess} places.");
            }
        }
    }
}

