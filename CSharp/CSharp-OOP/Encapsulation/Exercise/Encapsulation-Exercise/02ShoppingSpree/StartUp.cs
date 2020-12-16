using System;
using System.Collections.Generic;
using System.Linq;

namespace _02ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            List<Product> products = new List<Product>();

            try
            {
                ParsePeopleInput(persons);

                ParseProductsInput(products);

                string command;

                while ((command = Console.ReadLine()) != "END")
                {
                    string[] cmds = command.Split().ToArray();

                    string personName = cmds[0];
                    string productName = cmds[1];

                    Person person = persons.FirstOrDefault(p => p.Name == personName);

                    Product product = products.FirstOrDefault(p => p.Name == productName);

                    if (person != null && product != null)
                    {
                        string result = person.Buy(product);

                        Console.WriteLine(result);
                    }
                }

                foreach (var person in persons)
                {
                    Console.WriteLine(person.ToString());
                }
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                return;
            }
        }

        private static void ParseProductsInput(List<Product> products)
        {
            string[] productInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var productStr in productInput)
            {
                string[] splitted = productStr.Split('=', StringSplitOptions.RemoveEmptyEntries).ToArray();

                string name = splitted[0];
                decimal cost = decimal.Parse(splitted[1]);

                Product product = new Product(name, cost);

                products.Add(product);
            }
        }

        private static void ParsePeopleInput(List<Person> persons)
        {
            string[] peopleInput = Console.ReadLine().Split(';').ToArray();

            foreach (var personStr in peopleInput)
            {
                string[] splitted = personStr.Split('=').ToArray();

                string name = splitted[0];
                decimal money = decimal.Parse(splitted[1]);

                Person person = new Person(name, money);

                persons.Add(person);
            }
        }
    }
}
