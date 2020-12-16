using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split();

            string[] b = Console.ReadLine().Split();

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == b[i])
                    {
                        Console.Write(b[i] + " ");
                    }
                }
            }


        }
        
    }
}
