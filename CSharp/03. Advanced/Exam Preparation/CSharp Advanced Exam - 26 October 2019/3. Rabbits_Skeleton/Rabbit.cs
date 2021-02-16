using System;
using System.Collections.Generic;
using System.Text;

namespace Rabbits
{
    //            First, write a C# class Rabbit with the following properties:
    //•	Name: string
    //•	Species: string
    //•	Available: bool -true by default
    //The class constructor should receive name and species.Override the ToString() method in the following format:
    //"Rabbit ({species}): {name}"



    public class Rabbit
    {
        public Rabbit(string name, string species)
        {
            Name = name;
            Species = species;
            Available = true;
        }

        public string Name { get; set; }

        public string Species { get; set; }

        public bool Available { get; set; }

        public override string ToString()
        {
            return $"Rabbit ({Species}): {Name}";
        }

    }
}
