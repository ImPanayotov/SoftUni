using System;
using System.Collections.Generic;

namespace _01._Club_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());

            Stack<string> line = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            Queue<string> halls = new Queue<string>();
            Queue<string> reservation = new Queue<string>();


            for (int i = 0; i < line.Count; i++)
            {
                bool isNumber = int.TryParse(line.Peek(), out _);

                if (!isNumber)
                {
                    halls.Enqueue(line.Pop());
                }
                else
                {
                    reservation.Enqueue(line.Pop());
                }
            }

            // to finish it
            // if there is enough time
        }
    }
}
