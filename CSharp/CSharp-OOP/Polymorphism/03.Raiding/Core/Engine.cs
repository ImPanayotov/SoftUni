using _03.Raiding.Core.Interfaces;
using _03.Raiding.Factories;
using System;
using System.Collections.Generic;

namespace _03.Raiding.Core
{
    public class Engine : IEngine
    {
        public ICollection<BaseHero> heroes;
        public HeroFactory heroFactory;


        public Engine()
        {
            this.heroes = new List<BaseHero>();
            this.heroFactory = new HeroFactory();
        }


        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();

                BaseHero hero = null;

                try
                {
                    hero = this.heroFactory.CreateHero(name, type);
                    this.heroes.Add(hero);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                    i--;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            int totalPower = 0;
            
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                totalPower += hero.Power;
            }

            if (totalPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}
