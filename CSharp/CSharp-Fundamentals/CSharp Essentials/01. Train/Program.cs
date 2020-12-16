using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];


            int people = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                people = int.Parse(Console.ReadLine());
                wagons[i] += people;
               // Console.Write(wagons[i] + " ");
            }
            for (int i = 0; i < wagons.Length; i++)
            {
                Console.Write(wagons[i] + " ");
                
            }
            Console.WriteLine();
            Console.WriteLine(wagons.Sum());
            
        }
    }
}
