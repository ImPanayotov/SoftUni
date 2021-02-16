

namespace _06FoodShortage.Models
{
    public class Pet
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public string Birthday { get; private set; }

    }
}
