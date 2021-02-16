using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._On_the_Way_to_Annapurna
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> stores =
                new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split("->").ToArray();

                string cmd = input[0];

                if (cmd == "END")
                {
                    break;
                }

                if (cmd == "Add")
                {
                    string store = input[1];
                    string[] items = input[2].Split(",").ToArray();

                    if (!stores.ContainsKey(store))
                    {
                        stores.Add(store, new List<string>());
                    }

                    for (int i = 0; i < items.Length; i++)
                    {
                        stores[store].Add(items[i]);
                    }
                }
                else if (cmd == "Remove")
                {
                    string store = input[1];

                    if (stores.ContainsKey(store))
                    {
                        stores.Remove(store);
                    }
                }
            }

            Console.WriteLine("Stores list:");

            foreach (var store in stores
                .OrderByDescending(x => x.Value.Count)
                .ThenByDescending(x => x.Key))
            {
                Console.WriteLine(store.Key);

                foreach (var item in store.Value)
                {
                    Console.WriteLine($"<<{item}>>");
                }
            }
        }
    }
}
