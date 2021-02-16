using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            data = new List<Hero>();
        }

        public int Count { get { return data.Count; }}

        public void Add(Hero hero)
        {
           data.Add(hero);
        }

        public void Remove(string name)
        {
            Hero hero = data.FirstOrDefault(h => h.Name == name);

            if (hero != null)
            {
                data.Remove(hero);
            }
        }

       public Hero GetHeroWithHighestStrength()
        {
            Hero hero = data.OrderByDescending(h => h.Item.Strength).FirstOrDefault();

            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = data.OrderByDescending(h => h.Item.Ability).FirstOrDefault();

            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = data.OrderByDescending(h => h.Item.Intelligence).FirstOrDefault();

            return hero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < data.Count; i++)
            {
                sb.AppendLine(data[i].ToString());
            }
            return sb.ToString();
        }
    }
}
