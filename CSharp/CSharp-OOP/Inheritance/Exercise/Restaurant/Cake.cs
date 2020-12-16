using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private static double Grams = 250;
        private static double Calories = 1000;
        private static decimal CakePrice = 5;


        public Cake(string name) : base(name, CakePrice, Grams, Calories)
        {
            
        }

    }
}
