using System;

namespace _05._Fitness_center
{
    class Program
    {
        static void Main(string[] args)
        {

            int visitors = int.Parse(Console.ReadLine());

            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int shake = 0;
            int bar = 0;
            int training = 0;
            int shopping = 0;


            for (int i = 0; i < visitors; i++)
            {
                string activity = Console.ReadLine();
                if (activity == "Back")
                {
                    back++;
                    training++;
                }
                else if (activity == "Chest")
                {
                    chest++;
                    training++;
                }
                else if (activity == "Legs")
                {
                    legs++;
                    training++;
                }
                else if (activity == "Abs")
                {
                    abs++;
                    training++;
                }
                if (activity == "Protein shake")
                {
                    shake++;
                    shopping++;
                }
                else if (activity == "Protein bar")
                {
                    bar++;
                    shopping++;
                }
            }
                double shoppingCount = (shopping * 1.0 / (training + shopping)) * 100;
                double trainingCount = (training * 1.0 / (training + shopping)) * 100;
                Console.WriteLine($"{back} - back");
                Console.WriteLine($"{chest} - chest");
                Console.WriteLine($"{legs} - legs");
                Console.WriteLine($"{abs} - abs");
                Console.WriteLine($"{shake} - protein shake");
                Console.WriteLine($"{bar} - protein bar");
                Console.WriteLine($"{trainingCount:f2}% - work out ");
                Console.WriteLine($"{shoppingCount:f2}% - protein");

        }
    }
}
