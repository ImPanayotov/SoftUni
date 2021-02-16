using _07.MilitaryElite.Enumerations;

namespace _07.MilitaryElite.Models
{
    public interface IMission
    {
        string CodeName { get; }
        State State { get; }

        void CompleteMission();
    }
}