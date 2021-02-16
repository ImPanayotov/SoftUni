using System;
using System.Linq;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "find")
                {
                    break;
                }

                char[] inputAsChars = input.ToCharArray();
                int index = 0;

                for (int i = 0; i < inputAsChars.Length; i++)
                {
                    inputAsChars[i] = (char)(inputAsChars[i] - key[index]);
                    index++;
                    if (index >= key.Length)
                    {
                        index = 0;
                    }
                }

                input = new string(inputAsChars);

                int itemIndex1 = input.IndexOf('&') + 1;
                int itemIndex2 = input.LastIndexOf('&');
                int coordinatesIndex1 = input.IndexOf('<') + 1;
                int coordinatesIndex2 = input.IndexOf('>');

                string item = input.Substring(itemIndex1, itemIndex2 - itemIndex1);
                string coordinates = input.Substring(coordinatesIndex1, coordinatesIndex2 - coordinatesIndex1);

                Console.WriteLine($"Found {item} at {coordinates}");
            }
        }
    }
}
