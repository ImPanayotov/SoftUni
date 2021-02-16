using _07.MilitaryElite.Core;
using _07.MilitaryElite.Interfaces;
using _07.MilitaryElite.IO.Interfaces;
using _07.MilitaryElite.IO.Models;
using System;

namespace _07.MilitaryElite
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            IEngine engine = new Engine(reader, writer);

            engine.Run();

            // 60/100 in judge
        }
    }
}
