using System.Collections.Generic;

namespace _01.Logger.Models.Interfaces
{
    public interface ILogger
    {
        IReadOnlyCollection<IAppender> Appenders { get; }

        void Log(IError error);
    }
}
