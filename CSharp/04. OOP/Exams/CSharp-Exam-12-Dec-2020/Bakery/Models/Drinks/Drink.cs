using Bakery.Models.Drinks.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bakery.Models.Drinks
{
    public abstract class Drink : IDrink
    {
        private string name;
        private int portion;
        private decimal price;
        private string brand;

        protected Drink(string name, int portion, decimal price, string brand)
        {
            Name = name;
            Portion = portion;
            Price = price;
            Brand = brand;
        }

        //•	Name – string (If the name is null or whitespace throw an ArgumenException with message "Name cannot be null or white space!")
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or white space!");
                }

                name = value;
            }
        }
        //•	Portion – int (if the portion is less than or equal to 0, throw an ArgumentException with message "Portion cannot be less or equal to zero")
        public int Portion
        {
            get
            {
                return portion;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Portion cannot be less or equal to zero");
                }

                portion = value;
            }
        }
        //•	Price – decimal (if the price is less than or equal to 0, throw an ArgumentException with message "Price cannot be less or equal to zero")
        public decimal Price
        {
            get
            {
                return price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price cannot be less or equal to zero!");
                }

                price = value;
            }
        }
        //•	Brand -  string (If the brand is null or whitespace thrown ArgumentException with message "Brand cannot be null or white space!")
        public string Brand
        {
            get
            {
                return brand;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Brand cannot be null or white space!");
                }

                brand = value;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name} {Brand} - {Portion}ml - {Price:f2}lv";
        }
    }
}
