using _04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models.Animals
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double WeightMultiplier => 0.35;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Vegetable), typeof(Fruit), typeof(Seeds), typeof(Meat) };

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
