using _01.Logger.IOManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Logger.IOManagement
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
