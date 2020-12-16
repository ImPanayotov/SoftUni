using _01.Logger.Common;
using _01.Logger.Models.Appenders;
using _01.Logger.Models.Enumerations;
using _01.Logger.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Logger.Factories
{
    public class AppenderFactory
    {
        public AppenderFactory()
        {

        }

        public IAppender CreateAppender(string appenderType, ILayout layout, Level level, IFile file = null)
        {
            IAppender appender;

            if (appenderType == "ConsoleAppender")
            {
                appender = new ConsoleAppender(layout, level);
            }
            else if (appenderType == "FileAppender" && file != null)
            {
                appender = new FileAppender(layout, level, file);
            }
            else
            {
                throw new InvalidOperationException(GlobalConstants.InvalidAppenderType);
            }

            return appender;
        }
    }
}
