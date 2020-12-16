using _01.Logger.Common;
using _01.Logger.Factories;
using _01.Logger.IOManagement;
using _01.Logger.IOManagement.Interfaces;
using _01.Logger.Models.Enumerations;
using _01.Logger.Models;
using _01.Logger.Models.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _01.Logger.Models.PathManagement;
using _01.Logger.Models.Files;

namespace _01.Logger
{
    public class StartUp
    {
        //unfinished//
        private readonly LayoutFactory layoutFactory = new LayoutFactory();
        private readonly AppenderFactory appenderFactory = new AppenderFactory();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IPathManager pathManager = new PathManager("logs", "logs.txt");
            IFile file = new LogFile(pathManager);
            ILogger logger = SetUpLogger(n, reader, writer, file);

        }

        private static ILogger SetUpLogger(int appendersCnt,IReader reader, IWriter writer, IFile file)
        {
            ICollection<IAppender> appenders = new HashSet<IAppender>();

            for (int i = 0; i < appendersCnt; i++)
            {
                string[] appenderArgs = reader.ReadLine().Split().ToArray();

                string appenderType = appenderArgs[0];
                string layoutType = appenderArgs[1];

                bool hasError = false;

                Level level = this.ParseLevel(appenderArgs, writer, ref hasError);

                if (hasError)
                {
                    continue;
                }

                try
                {
                    ILayout layout = this.layoutFactory.CreateLayout(layoutType);
                    IAppender appender = this.appenderFactory.CreateAppender(appenderType, layout, level, file);

                    appenders.Add(appender);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            ILogger logger = new Logger(appenders);

            return logger;
        }

        private static Level ParseLevel(string[] levelStr, IWriter writer, ref bool hasError)
        {
            Level appenderLevel = Level.INFO;

            if (levelStr.Length == 3)
            {

                bool isEnumValid = Enum.TryParse(typeof(Level), levelStr[2], true, out object enumParsed);

                if (!isEnumValid)
                {
                    writer.WriteLine(GlobalConstants.InvalidLevelType);
                    hasError = true;
                }

                appenderLevel = (Level)enumParsed;
            }

            return appenderLevel;
        }
    }
}
