using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int vol = int.Parse(Console.ReadLine());
            int energyPer100 = int.Parse(Console.ReadLine());
            double sugarPer100 = double.Parse(Console.ReadLine());

            double energy = vol * energyPer100 / 100.0;
            double sugar = vol * sugarPer100 / 100.0;

            Console.WriteLine($"{vol}ml {name}: {energy}kcal, {sugar}g sugars");
        }
    }
}
