using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyUsers =
                new Dictionary<string, List<string>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(" -> ")
                    .ToArray();

                if (input[0] == "End")
                {
                    break;
                }

                string companyName = input[0];
                string employeeID = input[1];

                if (!companyUsers.ContainsKey(companyName))
                {
                    companyUsers.Add(companyName, new List<string>());
                }

                if (!companyUsers[companyName].Contains(employeeID))
                {
                    companyUsers[companyName].Add(employeeID);
                }
            }

            foreach (var name in companyUsers.OrderBy(x => x.Key))
            {
                Console.WriteLine(name.Key);

                foreach (var id in name.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
