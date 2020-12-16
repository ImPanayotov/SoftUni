using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int index = 0;
            int bestCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currCounter = 1;
                int currElement = arr[i];
                for (int currI = i + 1; currI < arr.Length; currI++)
                {
                    if (currElement == arr[currI])
                    {
                        currCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (currCounter > bestCount)
                {
                    bestCount = currCounter;
                    index = i;
                }
            }
            string result = "";
            for (int i = 0; i < bestCount; i++)
            {
                result += arr[index] + " ";
            }
            Console.WriteLine(result);

        }
    }
}
