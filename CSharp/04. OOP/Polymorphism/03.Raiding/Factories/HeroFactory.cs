using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Raiding.Factories
{
    public class HeroFactory
    {

        public BaseHero CreateHero(string name, string type)
        {
            BaseHero hero;

            if (type == "Druid")
            {
                hero = new Druid(name, 80);
            }
            else if (type == "Paladin")
            {
                hero = new Paladin(name, 100);
            }
            else if (type == "Rogue")
            {
                hero = new Rogue(name, 80);
            }
            else if (type == "Warrior")
            {
                hero = new Warrior(name, 100);
            }
            else
            {
                throw new InvalidOperationException("Invalid hero!");
            }

            return hero;
        }
    }
}
