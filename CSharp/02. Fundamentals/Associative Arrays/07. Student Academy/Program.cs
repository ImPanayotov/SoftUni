using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> academy =
                new Dictionary<string, List<double>>();


            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!academy.ContainsKey(name))
                {
                    academy.Add(name, new List<double>());
                }

                academy[name].Add(grade);
            }

            foreach (var kvp in academy.OrderByDescending(x => x.Value.Average())
                .Where(b => b.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}
