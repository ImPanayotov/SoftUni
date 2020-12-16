using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _07._Order_by_Age
{
    class People
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<People> people = new List<People>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                List<string> info = input.Split().ToList();

                string name = info[0];
                string id = info[1];
                int age = int.Parse(info[2]);

                People person = new People()
                {
                    Name = name,
                    Id = id,
                    Age = age

                };

                people.Add(person);
            }

            foreach (People person in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");

            }
        }
    }
}
