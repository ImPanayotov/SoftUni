using _07.MilitaryElite.Enumerations;

namespace _07.MilitaryElite.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}