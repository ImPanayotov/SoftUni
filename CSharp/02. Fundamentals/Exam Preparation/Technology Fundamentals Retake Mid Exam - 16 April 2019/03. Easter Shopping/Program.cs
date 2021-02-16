using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Easter_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shops = Console.ReadLine()
                .Split()
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];

                if (command == "Include")
                {
                    string shop = input[1];
                    shops.Add(shop);
                }
                else if (command == "Visit")
                {
                    string direction = input[1];
                    int count = int.Parse(input[2]);

                    if (direction == "first")
                    {
                        if (shops.Count >= count)
                        {
                            shops.RemoveRange(0, count);
                        }
                    }
                    else if (direction == "last")
                    {
                        if (shops.Count >= count)
                        {
                            shops.Reverse();
                            shops.RemoveRange(0, count);
                            shops.Reverse();
                        }
                    }
                }
                else if (command == "Prefer")
                {
                    int index1 = int.Parse(input[1]);
                    int index2 = int.Parse(input[2]);

                    if (index1 >= 0 && index1 < shops.Count && index2 >= 0 && index2 < shops.Count)
                    {
                        string temp = shops[index1];
                        shops[index1] = shops[index2];
                        shops[index2] = temp;
                    }
                }
                else if (command == "Place")
                {
                    string shop = input[1];
                    int index = int.Parse(input[2]) + 1;

                    if (index >=0 && index < shops.Count)
                    {
                        shops.Insert(index, shop);
                    }
                }
            }

            Console.WriteLine("Shops left:");
            Console.WriteLine(string.Join(" ", shops));
        }
    }
}
