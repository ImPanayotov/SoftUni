using _04.WildFarm.Models.Foods.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Models.Foods
{
    public abstract class Food : IFood
    {
        protected Food(int quantity)
        {
            Quantity = quantity;
        }

        public int Quantity { get; }
    }
}
