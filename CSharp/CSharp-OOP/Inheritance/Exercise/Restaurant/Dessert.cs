using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dessert : Food
    {
        private double Calories;


        public Dessert(string name, decimal price, double grams, double calories) : base(name, price, grams)
        {
            this.Calories = calories;
        }
    }
}
