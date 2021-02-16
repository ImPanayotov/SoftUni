using _06FoodShortage.Core;
using _06FoodShortage.Interfaces;


namespace _06FoodShortage.Models
{
    public class Citizen : IName, IBuyer
    {
        private int food;

        public Citizen()
        {
            this.food = 0;
        }
        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthday = birthday;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Id { get; private set; }
        public string Birthday { get; private set; }
        public int Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }


        public void BuyFood()
        {
            this.Food += 10;
        }

       
    }
}
