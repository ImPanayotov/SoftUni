using _05.BirthdayCelebrations.Interfaces;
using _05.BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BirthdayCelebrations.Core
{
    public class Engine
    {
        private List<IBirthday> inhabitants;

        public Engine()
        {
            this.inhabitants = new List<IBirthday>();
        }
        public void Run()
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] splitted = input.Split().ToArray();
                if (splitted[0] == "Citizen")
                {
                    CreateCitizen(splitted);
                }
                else if (splitted[0] == "Pet")
                {
                    CreatePet(splitted);
                }

            }

            string requiredBirthdate = Console.ReadLine();


            foreach (var inhabitant in inhabitants)
            {
                if (inhabitant.Birthday.EndsWith(requiredBirthdate))
                {
                    Console.WriteLine(inhabitant.Birthday);
                }
            }


        }

        private void CreatePet(string[] splitted)
        {
            string name = splitted[1];
            string birthday = splitted[2];

            Pet pet = new Pet(name, birthday);

            inhabitants.Add(pet);
        }


        private void CreateCitizen(string[] splitted)
        {
            string name = splitted[1];
            int age = int.Parse(splitted[2]);
            string id = splitted[3];
            string birthday = splitted[4];

            Citizen citizen = new Citizen(name, age, id, birthday);

            inhabitants.Add(citizen);
        }
    }
}
