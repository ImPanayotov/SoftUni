using Animals.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Factories
{
    public class AnimalFactory
    {
        public Animal CreateAnimal(string type, string name, int age, string gender)
        {
            Animal animal;

            if (type == "Cat")
            {
                animal = new Cat(name, age, gender);
            }
            else if (type == "Tomcat")
            {
                animal = new Tomcat(name, age);
            }
            else if (type == "Kitten")
            {
                animal = new Kitten(name, age);
            }
            else if (type == "Dog")
            {
                animal = new Dog(name, age, gender);
            }
            else if (type == "Frog")
            {
                animal = new Frog(name, age, gender);
            }
            else
            {
                throw new ArgumentException("Invalid input!");
            }

            return animal;
        }
    }
}
