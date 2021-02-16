using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] names = new int[lines];
            string vowels = "aeiouAEIOU";

            for (int i = 0; i < lines; i++)
            {
                string name = Console.ReadLine();
                int[] letters = new int[name.Length];

                for (int j = 0; j < name.Length; j++)
                {
                    int vowelSum = 0;
                    int consonantSum = 0;
                    if (vowels.Contains(name[j]))
                    {
                        vowelSum += name[j] * name.Length;
                    }
                    else // It doesn't work if you check only for consonant letters like "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ"!
                    {
                        consonantSum += name[j] / name.Length;
                    }

                    letters[j] = vowelSum + consonantSum;
                }
                names[i] = letters.Sum();
            }

            Array.Sort(names);

            foreach (int item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}