using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, Dictionary<string, int>> heroes =
                new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string heroName = input[0];
                int HP = int.Parse(input[1]);
                int MP = int.Parse(input[2]);

                heroes.Add(heroName, new Dictionary<string, int>());
                heroes[heroName].Add("HP", HP);
                heroes[heroName].Add("MP", MP);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" - ").ToArray();

                string command = input[0];

                if (command == "End")
                {
                    break;
                }

                if (command == "CastSpell")
                {
                    string heroName = input[1];
                    int MPNeeded = int.Parse(input[2]);
                    string spellName = input[3];

                    if (MPNeeded <= heroes[heroName]["MP"])
                    {
                        heroes[heroName]["MP"] -= MPNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName]["MP"]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (command == "TakeDamage")
                {
                    string heroName = input[1];
                    int damage = int.Parse(input[2]);
                    string attacker = input[3];

                    if (damage < heroes[heroName]["HP"])
                    {
                        heroes[heroName]["HP"] -= damage;
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName]["HP"]} HP left!");
                    }
                    else
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }

                }
                else if (command == "Recharge")
                {
                    string heroName = input[1];
                    int MPAmount = int.Parse(input[2]);

                    if (heroes[heroName]["MP"] + MPAmount > 200)
                    {
                        Console.WriteLine($"{heroName} recharged for {200 -  heroes[heroName]["MP"]} MP!");
                        heroes[heroName]["MP"] = 200;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} recharged for {MPAmount} MP!");
                        heroes[heroName]["MP"] += MPAmount;
                    }
                }
                else if (command == "Heal")
                {
                    string heroName = input[1];
                    int HPAmount = int.Parse(input[2]);

                    if (heroes[heroName]["HP"] + HPAmount > 100)
                    {
                        Console.WriteLine($"{heroName} healed for {100 - heroes[heroName]["HP"]} HP!");
                        heroes[heroName]["HP"] = 100;
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} healed for {HPAmount} HP!");
                        heroes[heroName]["HP"] += HPAmount;
                    }
                }
            }


            foreach (var hero in heroes.OrderByDescending(x => x.Value["HP"]).ThenBy(x => x.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value["HP"]}");
                Console.WriteLine($"  MP: {hero.Value["MP"]}");
            }
        }
    }
}
