using _06FoodShortage.Interfaces;
using _06FoodShortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _06FoodShortage.Core
{
    public class Engine
    {
        private List<IBuyer> citizens;
        private List<IBuyer> rebels;

        public Engine()
        {
            this.citizens = new List<IBuyer>();
            this.rebels = new List<IBuyer>();
        }
        public void Run()
        {
            int n = int.Parse(Console.ReadLine());

            int totalAmountOfFood = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();


                if (input.Length == 4)
                {
                    CreateCitizen(input);
                }
                else if (input.Length == 3)
                {
                    CreateRebel(input);
                }
            }

            string inputName;

            while ((inputName = Console.ReadLine()) != "End")
            {
                string name = inputName;

                if (citizens.Any(c => c.Name == name))
                {
                    totalAmountOfFood += 10;
                }

                if (rebels.Any(r => r.Name == name))
                {
                    totalAmountOfFood += 5;
                }
            }

            

            Console.WriteLine(totalAmountOfFood);

        }

        private void CreateRebel(string[] input)
        {
            string name = input[0];

            if (!rebels.Any(r => r.Name == name))
            {
                int age = int.Parse(input[1]);
                string group = input[2];

                Rebel rebel = new Rebel(name, age, group);
                rebels.Add(rebel);
            }
        }


        private void CreateCitizen(string[] input)
        {
            string name = input[0];

            if (!citizens.Any(c => c.Name == name))
            {
                int age = int.Parse(input[1]);
                string id = input[2];
                string birthdate = input[3];

                Citizen citizen = new Citizen(name, age, id, birthdate);
                citizens.Add(citizen);
            }
        }
    }
}

