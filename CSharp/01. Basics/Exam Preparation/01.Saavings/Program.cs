using System;

namespace _01.Saavings
{
    class Program
    {
        static void Main(string[] args)
        {
            //dohoda na desi
            double income = double.Parse(Console.ReadLine());
            //meseci, za koito traybva da gi sybere
            int months = int.Parse(Console.ReadLine());
            double spendings = double.Parse(Console.ReadLine());

            double savings = income * 0.3;
            double totalSavings = income - (savings + spendings);
            double total = months * totalSavings;
            double totalPerCent = total * 2;
            double percent = ((totalSavings / income) * 100);
            Console.WriteLine($"She can save {percent:f2}%");
            Console.WriteLine($"{total:f2}");
            

        }
    }
}
