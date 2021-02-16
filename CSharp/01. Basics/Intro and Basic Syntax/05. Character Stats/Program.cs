using System;

namespace _05._Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            int remainingHealth = maxHealth - currentHealth;
            string currentHealthAsString = new string('|', currentHealth);
            string remainingHealthAsString = new string('.', remainingHealth);
            string healthBar = $"|{currentHealthAsString}{remainingHealthAsString}|";

            int remainingEnergy = maxEnergy - currentEnergy;
            string currentEnergyAsString = new string('|', currentEnergy);
            string remainingEnergyAsString = new string('.', remainingEnergy);
            string energyBar = $"|{currentEnergyAsString}{remainingEnergyAsString}|";

            Console.WriteLine($"Health: {healthBar}");
            Console.WriteLine($"Energy: {energyBar}");
        }
    }
}
