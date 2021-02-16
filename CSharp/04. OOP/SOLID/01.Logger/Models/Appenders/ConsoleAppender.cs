using _01.Logger.Common;
using _01.Logger.IOManagement;
using _01.Logger.Models.Enumerations;
using _01.Logger.Models.Interfaces;
using System;

namespace _01.Logger.Models.Appenders
{
    public class ConsoleAppender : Appender
    {
        private readonly IWriter writer;


        public ConsoleAppender(ILayout layout, Level level) : base(layout, level)
        {
            this.writer = new ConsoleWriter();
        }



        public override void Append(IError error)
        {
            string format = this.Layout.Format;
            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;

            string formattedString = string.Format(format, dateTime.ToString(GlobalConstants.DateTimeFormat), level.ToString(), message);

            this.writer.WriteLine(formattedString);
            this.messagesAppended++;
        }


    }
}
