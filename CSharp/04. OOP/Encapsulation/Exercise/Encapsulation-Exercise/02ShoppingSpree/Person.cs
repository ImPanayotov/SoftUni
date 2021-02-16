using System;
using System.Collections.Generic;
using System.Text;

namespace _02ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            bag = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }


        public string Buy(Product product)
        {
            if (this.money < product.Cost)
            {
               return $"{this.name} can't afford {product.Name}";
            }

            this.Money -= product.Cost;
            this.bag.Add(product);

            return $"{this.name} bought {product.Name}";
        }


        public override string ToString()
        {
            string productsOutput = this.bag.Count > 0 ? string.Join(", ", this.bag) : "Nothing bought";

            return $"{this.name} - {productsOutput}";
        }
    }
}
