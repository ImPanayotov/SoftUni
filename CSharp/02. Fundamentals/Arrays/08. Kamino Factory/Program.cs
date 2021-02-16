using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_Kamino_Facotry
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            int defLength = int.MinValue;
            int defIndex = int.MinValue;
            int defSum = int.MinValue;
            int defStart = -1;
            int index = 1;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                int[] data = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentLength = int.MinValue, currentIndex = int.MinValue, currentSubLength = 0, currentSubIndex = 0;
                bool isOne = false;

                for (int i = 0; i < length; i++)
                {
                    if (data[i] == 1 && isOne)
                    {
                        currentSubLength++;
                    }
                    else if (data[i] == 1)
                    {
                        isOne = true;
                        currentSubIndex = i;
                        currentSubLength = 1;
                    }
                    else if (data[i] == 0 && isOne)
                    {
                        if (currentSubLength > currentLength)
                        {
                            currentLength = currentSubLength;
                            currentIndex = currentSubIndex;
                        }
                        isOne = false;
                        currentSubLength = 0;
                        currentSubIndex = 0;
                    }
                }

                if (isOne)
                {
                    if (currentSubLength > currentLength)
                    {
                        currentLength = currentSubLength;
                        currentIndex = currentSubIndex;
                    }
                }

                if (currentLength > defLength)
                {
                    defLength = currentLength;
                    defIndex = currentIndex;
                    defSum = data.Sum();
                    arr = data;
                    defStart = index;
                }
                else if (currentLength == defLength)
                {
                    if (currentIndex < defIndex)
                    {
                        defLength = currentLength;
                        defIndex = currentIndex;
                        defSum = data.Sum();
                        arr = data;
                        defStart = index;
                    }
                    else if (currentIndex == defIndex)
                    {
                        if (data.Sum() > defSum)
                        {
                            defLength = currentLength;
                            defIndex = currentIndex;
                            defSum = data.Sum();
                            arr = data;
                            defStart = index;
                        }
                    }
                }
                index++;
            }

            Console.WriteLine($"Best DNA sample {defStart} with sum: {defSum}.");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}