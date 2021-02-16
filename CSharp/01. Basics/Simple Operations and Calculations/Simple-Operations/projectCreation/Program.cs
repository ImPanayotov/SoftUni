using System;

namespace projectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int projectsCount = int.Parse(Console.ReadLine());
            int hours = projectsCount * 3;
            Console.WriteLine($"The architect {name} will need {hours} hours to complete {projectsCount} project/s.");
        }
    }
}
