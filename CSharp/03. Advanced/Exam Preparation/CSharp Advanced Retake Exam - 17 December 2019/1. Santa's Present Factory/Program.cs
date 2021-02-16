using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1._Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> materials = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Queue<int> magicLevel = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int dolls = 0;
            int trains = 0;
            int bears = 0;
            int bicycles = 0;

            while (materials.Count > 0 && magicLevel.Count > 0)
            {
                int sum = materials.Peek() * magicLevel.Peek();

                if (sum == 150)
                {
                    dolls++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (sum == 250)
                {
                    trains++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (sum == 300)
                {
                    bears++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (sum == 400)
                {
                    bicycles++;
                    materials.Pop();
                    magicLevel.Dequeue();
                }
                else if (sum < 0)
                {
                    materials.Push(materials.Pop() + magicLevel.Dequeue());
                }
                else if (sum > 0)
                {
                    magicLevel.Dequeue();
                    materials.Push(materials.Pop() + 15);
                }
                else if (magicLevel.Peek() == 0 || materials.Peek() == 0)
                {
                    if (materials.Peek() == 0)
                    {
                        materials.Pop();
                    }

                    if (magicLevel.Peek() == 0)
                    {
                        magicLevel.Dequeue();
                    }
                }
            }

            if ((dolls > 0 && trains > 0) || (bears > 0 && bicycles > 0))
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Count > 0)
            {
                Console.Write("Materials left: " + string.Join(", ", materials));
                Console.WriteLine();
            }

            if (magicLevel.Count > 0)
            {
                Console.Write("Magic left: " + string.Join(", ", magicLevel));
                Console.WriteLine();
            }

            if (bicycles > 0)
            {
                Console.WriteLine($"Bicycle: {bicycles}");
            }

            if (dolls > 0)
            {
                Console.WriteLine($"Doll: {dolls}");
            }

            if (bears > 0)
            {
                Console.WriteLine($"Teddy bear: {bears}");
            }

            if (trains > 0)
            {
                Console.WriteLine($"Wooden train: {trains}");
            }
        }
    }
}
