using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKgVegetable = double.Parse(Console.ReadLine());
            double pricePerKgFruit = double.Parse(Console.ReadLine());
            double vegetableKg = double.Parse(Console.ReadLine());
            double fruitKg = double.Parse(Console.ReadLine());

            double fruits = pricePerKgFruit * fruitKg;
            double vegetable = pricePerKgVegetable * vegetableKg;
            double total = (fruits + vegetable) / 1.94;
            Console.WriteLine($"{total:f2}");
        }
    }
}
