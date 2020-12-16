using System;
using System.Linq;

namespace _01_Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());

            int[] numOfPeople = new int[countOfWagons];
            int sumOfPeople = 0;

            for (int i = 0; i < numOfPeople.Length; i++)
            {
                numOfPeople[i] = int.Parse(Console.ReadLine());
                sumOfPeople += numOfPeople[i];
            }

            for (int i = 0; i < numOfPeople.Length; i++)
            {
                Console.Write($"{numOfPeople[i]} ");

            }
            Console.WriteLine();
            Console.WriteLine(sumOfPeople);
        }
    }
}
