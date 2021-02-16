using Animals.Core.Contracts;
using Animals.Factories;
using Animals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals.Core
{
    class Engine : IEngine
    {
        private readonly List<Animal> animals;
        private AnimalFactory animalfactory;

        public Engine()
        {
            this.animals = new List<Animal>();
            this.animalfactory = new AnimalFactory();

        }
        public void Run()
        {
            

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Beast!")
                {
                    break;
                }

                string[] args = Console.ReadLine().Split().ToArray();

                string type = input;
                string name = args[0];
                int age = int.Parse(args[1]);
                string gender = args[2];

                Animal animal;

                try
                {
                    animal = animalfactory.CreateAnimal(type, name, age, gender);

                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }

                animals.Add(animal);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
