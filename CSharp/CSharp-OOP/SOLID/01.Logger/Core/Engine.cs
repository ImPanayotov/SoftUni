using _01.Logger.Core.Interfaces;
using _01.Logger.Factories;
using _01.Logger.IOManagement;
using _01.Logger.IOManagement.Interfaces;
using _01.Logger.Models.Enumerations;
using _01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Logger.Core
{
    public class Engine : IEngine
    {
        private readonly ILogger logger;
        private readonly IReader reader;
        private readonly IWriter writer;
        
        public Engine(ILogger logger, IReader reader, IWriter writer)
        {
            this.logger = logger;
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            string cmd;

            while ((cmd = this.reader.ReadLine()) != "END")
            {
                string[] errorArgs = cmd.Split().ToArray();

                string levelStr = errorArgs[0];
                string dateTimeStr = errorArgs[1];
                string message = errorArgs[2];

                bool isLevelValid = Enum.TryParse(typeof(Level), levelStr, true, out object levelObject);

                if (!isLevelValid)
                {

                }

                try
                {
                    
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
