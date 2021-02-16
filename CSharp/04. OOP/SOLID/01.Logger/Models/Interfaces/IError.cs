using _01.Logger.Models.Enumerations;
using System;

namespace _01.Logger.Models.Interfaces
{
    public interface IError
    {
        DateTime DateTime { get; }

        string Message { get; }

        Level Level { get; }
    }
}