using _01.Logger.Models.Interfaces;


namespace _01.Logger.Models
{
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
