using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirateship = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            List<int> warship = Console.ReadLine()
                .Split(">")
                .Select(int.Parse)
                .ToList();

            int maxHealth = int.Parse(Console.ReadLine());

            while (true)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string command = input[0];

                if (command == "Retire")
                {

                    Console.WriteLine($"Pirate ship status: {pirateship.Sum()}");
                    Console.WriteLine($"Warship status: {warship.Sum()}");
                    break;
                }
                if (command == "Fire")
                {
                    int index = int.Parse(input[1]);
                    int damage = int.Parse(input[2]);
                    if (index >= 0 && index < warship.Count)
                    {
                        Fire(pirateship, warship, index, damage);

                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }

                    }
                }
                else if (command == "Defend")
                {
                    int start = int.Parse(input[1]);
                    int end = int.Parse(input[2]);
                    int damage = int.Parse(input[3]);

                    Defend(pirateship, warship, start, end, damage);

                    for (int i = 0; i < pirateship.Count; i++)
                    {
                        if (pirateship[i] <= 0)
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(input[1]);
                    int health = int.Parse(input[2]);

                    Repair(pirateship, warship, index, health, maxHealth);
                }
                else if (command == "Status")
                {
                    Status(pirateship, warship, maxHealth);
                }
            }
        }

        public static List<int> Fire(List<int> pirateship, List<int> warship, int index, int damage)
        {
            if (index >= 0 && index < warship.Count)
            {
                warship[index] -= damage;

                if (warship[index] <= 0)
                {

                }
            }

            return warship;
        }

        public static List<int> Defend(List<int> pirateship, List<int> warship, int start, int end, int damage)
        {
            if ((start >= 0 && start < pirateship.Count) && (end >= 0 && end < pirateship.Count) && start <= end)
            {
                for (int i = start; i <= end; i++)
                {
                    pirateship[i] -= damage;
                }
            }

            return pirateship;
        }

        public static List<int> Repair(List<int> pirateship, List<int> warship, int index, int health, int maxHealth)
        {
            if (index >= 0 && index < pirateship.Count)
            {
                pirateship[index] += health;
                if (pirateship[index] > maxHealth)
                {
                    pirateship[index] = maxHealth;
                }
            }
            return pirateship;
        }

        public static void Status(List<int> pirateship, List<int> warship, int maxHealth)
        {
            double twentyOfMax = maxHealth / 5.0;
            int count = 0;
            for (int i = 0; i < pirateship.Count; i++)
            {
                if (pirateship[i] < twentyOfMax)
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine($"{count} sections need repair.");
            }
        }
    }
}
