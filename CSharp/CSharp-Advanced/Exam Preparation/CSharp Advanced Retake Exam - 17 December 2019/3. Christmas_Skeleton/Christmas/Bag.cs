using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Christmas
{
    class Bag
    {

        private List<Present> data;

        public Bag(string color, int capacity)
        {
            Color = color;
            Capacity = capacity;
            data = new List<Present>();
        }

        public string Color { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }

        // •	Method Add(Present present) - adds an entity to the data if there is room for it
        //•	Method Remove(string name) - removes a present by given name, if such exists, and returns bool
        //•	Method GetHeaviestPresent() - returns the heaviest present
        //•	Method GetPresent(string name) - returns the present with the given name
        //•	Getter Count - returns the number of presents
        //•	Report() - returns a string in the following format(print the presents in order of appearance) :
        //o	"{color of Bag} bag contains:
        //{Present1
        //    }
        //{Present2
        //}
        //(…)"
        public void Add(Present present)
        {
            if (data.Count < Capacity)
            {
                data.Add(present);
            }
        }

        public bool Remove(string name)
        {
            Present presentToRemove = data.FirstOrDefault(p => p.Name == name);

            if (presentToRemove != null)
            {
                data.Remove(presentToRemove);

                return true;
            }

            return false;
        }

        public Present GetHeaviestPresent()
        {
            Present heaviestPresent = data.OrderByDescending(p => p.Weight).First();

            return heaviestPresent;
        }

        public Present GetPresent(string name)
        {
            Present presentToGet = data.FirstOrDefault(p => p.Name == name);

            return presentToGet;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Color} bag contains:");

            foreach (var present in data)
            {
                sb.AppendLine(present.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
