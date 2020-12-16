using System;

namespace Reverse_array_of_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - i - 1];
                names[names.Length - i - 1] = temp;
            }
            Console.WriteLine(string.Join(" ", names));

           
        }
    }
}
