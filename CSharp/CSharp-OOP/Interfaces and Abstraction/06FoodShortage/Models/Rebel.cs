using _06FoodShortage.Core;
using _06FoodShortage.Interfaces;


namespace _06FoodShortage.Models
{
    public class Rebel : IName, IBuyer
    {
        private int food = 0;

        public Rebel()
        {
            this.food = 0;

        }
        public Rebel(string name, int age, string group)
        {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
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
            this.Food += 5;

        }
    }
}
