using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Flower_Wreaths
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int wreaths = 0;
            int storedFlowers = 0;

            int count = Math.Min(lilies.Count, roses.Count);

            for (int i = 0; i < count; i++)
            {
                if (lilies.Peek() + roses.Peek() == 15)
                {
                    wreaths++;
                    lilies.Pop();
                    roses.Dequeue();
                }
                else if (lilies.Peek() + roses.Peek() > 15)
                {
                    while (true)
                    {
                        lilies.Push(lilies.Pop() - 2);

                        if (lilies.Peek() + roses.Peek() == 15)
                        {
                            wreaths++;
                            lilies.Pop();
                            roses.Dequeue();
                            break;
                        }
                        else if (lilies.Peek() + roses.Peek() < 15)
                        {
                            storedFlowers += lilies.Peek() + roses.Peek();
                            lilies.Pop();
                            roses.Dequeue();
                            break;
                        }
                    }
                }
                else
                {
                    storedFlowers += lilies.Pop() + roses.Dequeue();
                }
            }


            while (storedFlowers >= 15)
            {
                wreaths++;
                storedFlowers -= 15;
            }

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
