using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keyMaterialsNames = new string[]
            {
                "shards",
                "fragments",
                "motes"
            };

            string itemObtained = string.Empty;

            bool obtained = false;

            Dictionary<string, long> keyMaterials = new Dictionary<string, long>();

            Dictionary<string, long> junk = new Dictionary<string, long>();

            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;

            while (!obtained)
            {
                string[] inputArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < inputArgs.Length; i += 2)
                {
                    long qty = long.Parse(inputArgs[i]);
                    string material = inputArgs[i + 1].ToLower();

                    if (keyMaterialsNames.Contains(material))
                    {
                        keyMaterials[material] += qty;

                        if (keyMaterials.Any(m => m.Value >= 250))
                        {
                            if (material == "shards")
                            {
                                itemObtained = "Shadowmourne";
                            }
                            else if (material == "fragments" )
                            {
                                itemObtained = "Valanyr";
                            }
                            else
                            {
                                itemObtained = "Dragonwrath";
                            }

                            keyMaterials[material] -= 250;

                            obtained = true;
                            break;
                        }
                    }
                    else
                    {
                        AddJunk(junk, qty, material);
                    }
                }
            }

            Console.WriteLine($"{itemObtained} obtained!");

            keyMaterials = keyMaterials
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in keyMaterials)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            junk = junk
                .OrderBy(kvp => kvp.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var kvp in junk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        private static void AddJunk(Dictionary<string, long> junk, long qty, string material)
        {
            if (!junk.ContainsKey(material))
            {
                junk[material] = 0;
            }

            junk[material] += qty;
        }
    }
}
