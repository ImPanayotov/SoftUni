using _07.MilitaryElite.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.IO.Models
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            Console.Write(text);
        }
        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
