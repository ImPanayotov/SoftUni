using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> cupsCapacityArray = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bottlesArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            Stack<int> bottles = new Stack<int>(bottlesArray);

            int waste = 0;

            while (cupsCapacityArray.Count != 0 && bottles.Count != 0)
            {
                int tempBottle = bottles.Peek();

                cupsCapacityArray[0] -= tempBottle;

                if (cupsCapacityArray[0] < 0)
                {
                    waste += Math.Abs(cupsCapacityArray[0]);
                    bottles.Pop();
                    cupsCapacityArray.RemoveAt(0);
                }
                else if (cupsCapacityArray[0] == 0)
                {
                    bottles.Pop();
                    cupsCapacityArray.RemoveAt(0);
                }
                else
                {
                    bottles.Pop();
                }
            }

            if (cupsCapacityArray.Count == 0)
            {
                Console.WriteLine($"Bottles: " + string.Join(" ", bottles));
            }
            else if (bottles.Count == 0)
            {
                Console.WriteLine($"Cups: "+ string.Join(" ", cupsCapacityArray));

            }

            Console.WriteLine($"Wasted litters of water: {waste}");
        }
    }
}
