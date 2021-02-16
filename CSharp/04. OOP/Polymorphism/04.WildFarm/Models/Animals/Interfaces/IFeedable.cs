using _04.WildFarm.Models.Foods.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models.Animals.Interfaces
{
    public interface IFeedable
    {
        void Feed(IFood food);

        int FoodEaten { get; }

        double WeightMultiplier { get; }

        ICollection<Type> PreferredFoods { get; }
    }
}
