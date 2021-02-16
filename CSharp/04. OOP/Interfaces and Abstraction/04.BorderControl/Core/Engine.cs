using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BorderControl.Core
{
    public class Engine
    {
        private List<IId> inhabitants;

        public Engine()
        {
            this.inhabitants = new List<IId>();
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

                if (splitted.Length == 3)
                {
                    CreateCitizen(splitted);
                }
                else
                {
                    CreateRobot(splitted);
                }
            }

            string fakeIDsDigits = Console.ReadLine();

            foreach (var inhabitant in inhabitants)
            {
                if (inhabitant.Id.EndsWith(fakeIDsDigits))
                {
                    Console.WriteLine(inhabitant.Id);
                }
            }

        }

        private void CreateRobot(string[] splitted)
        {
            string model = splitted[0];
            string id = splitted[1];

            Robots robot = new Robots(model, id);

            inhabitants.Add(robot);
        }

        private void CreateCitizen(string[] splitted)
        {
            string name = splitted[0];
            int age = int.Parse(splitted[1]);
            string id = splitted[2];

            Citizens citizen = new Citizens(name, age, id);

            inhabitants.Add(citizen);
        }
    }
}
