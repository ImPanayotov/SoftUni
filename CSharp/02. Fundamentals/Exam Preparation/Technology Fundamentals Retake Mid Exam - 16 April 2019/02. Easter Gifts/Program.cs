using System;
using System.Linq;

namespace _02._Easter_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] gifts = Console.ReadLine()
                .Split()
                .ToArray();

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];
                string command2 = input[1];

                if (command == "No" && command2 == "Money")
                {
                    break;
                }

                if (command == "OutOfStock")
                {
                    string name = input[1];

                    for (int i = 0; i < gifts.Length; i++)
                    {
                        if (gifts[i] == name)
                        {
                            gifts[i] = "None";
                        }
                    }
                }
                else if (command == "Required")
                {
                    string name = input[1];
                    int index = int.Parse(input[2]);

                    if (index >= 0 && index < gifts.Length)
                    {
                        gifts[index] = name;
                    }
                }
                else if (command == "JustInCase")
                {
                    string name = input[1];
                    gifts[gifts.Length - 1] = name;
                }
            }

            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i] != "None")
                {
                    Console.Write(gifts[i] + " ");
                }
            }
        }
    }
}
