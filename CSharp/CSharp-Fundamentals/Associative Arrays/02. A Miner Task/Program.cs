using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> materialRepository = new Dictionary<string, long>();

            string product;

            while ((product = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!materialRepository.ContainsKey(product))
                {
                    materialRepository[product] = 0;
                }

                materialRepository[product] += quantity;
            }

            foreach (var kvp in materialRepository)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
