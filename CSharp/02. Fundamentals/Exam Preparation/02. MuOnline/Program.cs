using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            double health = 100.0;
            double bitcoins = 0.0;
            double currentHealth = 100;

            string[] input = Console.ReadLine().Split("|");

            for (int i = 0; i < input.Length; i++)
            {
                double currentBitcoins = 0;
                string[] command = input[i].Split();
                double potionHP = 0;
                string monsterName = string.Empty;
                double monsterPower = 0.0;

                if (command[0] == "potion")
                {
                    potionHP = int.Parse(command[1]);

                    if (currentHealth + potionHP > 100)
                    {
                        Console.WriteLine($"You healed for {health - currentHealth} hp.");
                        currentHealth = 100;
                        Console.WriteLine($"Current health: {currentHealth} hp.");
                    }
                    else 
                    {
                        currentHealth += potionHP;
                        Console.WriteLine($"You healed for {potionHP} hp.");
                        Console.WriteLine($"Current health: {currentHealth} hp.");
                    }
                }
                else if (command[0] == "chest")
                {
                    currentBitcoins = double.Parse(command[1]);
                    bitcoins += currentBitcoins;
                    Console.WriteLine($"You found {currentBitcoins} bitcoins.");
                }
                else
                {
                    monsterName = command[0];
                    monsterPower = double.Parse(command[1]);
                    currentHealth -= monsterPower;
                    if (currentHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {monsterName}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                }
            }
            if (currentHealth > 0)
            {
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {currentHealth}");
            }
        }
    }
}
