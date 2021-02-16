using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {

        //        Next, write a C# class Cage that has data (a collection which stores the entity Rabbit). All entities inside the repository have the same properties. Also, the Cage class should have those properties:
        //•	Name: string
        //•	Capacity: int
        //The class constructor should receive name and capacity, also it should initialize the data with a new instance of the collection.Implement the following features:
        //•	Field data - collection that holds added rabbits


        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            data = new List<Rabbit>();
        }

        //•	Method Add(Rabbit rabbit) - adds an entity to the data if there is room for it
        //•	Method RemoveRabbit(string name) - removes a rabbit by given name, if such exists, and returns bool
        //•	Method RemoveSpecies(string species) - removes all rabbits by given species
        //•	Method SellRabbit(string name) - sell (set its Available property to false without removing it from the collection) the first rabbit with the given name, also return the rabbit
        //•	Method SellRabbitsBySpecies(string species) - sells(set their Available property to false without removing them from the collection) and returns all rabbits from that species as an array
        //•	Getter Count - returns the number of rabbits
        //•	Report() - returns a string in the following format, including only not sold rabbits:	
        //o	"Rabbits available at {cageName}:
        //{Rabbit1
        //    }
        //{Rabbit2
        //}
        //(…)"
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return data.Count; } }


        public void Add(Rabbit rabbit)
        {
            if (data.Count < Capacity)
            {
                data.Add(rabbit);
            }
        }

        public bool RemoveRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);

            if (rabbit != null)
            {
                data.Remove(rabbit);
                return true;
            }

            return false;
        }

        //public void RemoveSpecies(string species)
        //{
        //    Rabbit rabbit = data.FirstOrDefault(r => r.Species == species);

        //    if (rabbit != null)
        //    {
        //        data.Remove(rabbit);
        //    }
        //}
        public void RemoveSpecies(string species)
        {
            this.data = this.data.Where(r => r.Species != species).ToList();
        }

        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = data.FirstOrDefault(r => r.Name == name);

            if (rabbit != null)
            {
                rabbit.Available = false;
            }

            return rabbit;
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            Rabbit[] rabbits = data.Where(r => r.Species == species).ToArray();

            if (rabbits != null)
            {
                foreach (Rabbit rabbit in rabbits)
                {
                    rabbit.Available = false;
                }
            }



            return rabbits;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at {Name}:");

            foreach (Rabbit rabbit in data.Where(r => r.Available == true))
            {
                sb.AppendLine(rabbit.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}


