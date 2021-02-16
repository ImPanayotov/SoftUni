using _01.Logger.Models.Enumerations;

namespace _01.Logger.Models.Interfaces
{
    public interface IAppender
    {
        ILayout Layout { get; }

        Level Level { get; }

        void Append(IError error);
    }
}
