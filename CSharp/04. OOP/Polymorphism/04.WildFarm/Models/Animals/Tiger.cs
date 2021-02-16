using _04.WildFarm.Models.Foods;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models.Animals
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override double WeightMultiplier => 1.0;

        public override ICollection<Type> PreferredFoods => new List<Type>() { typeof(Meat) };

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
