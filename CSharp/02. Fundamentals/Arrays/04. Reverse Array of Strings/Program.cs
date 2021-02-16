using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;

            }
            Console.WriteLine(string.Join(" ", names));
        }
    }
}
