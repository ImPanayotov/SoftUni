using System;

namespace _01._School_supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            double cleaningPerLiter = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double pensPrice = 5.80;
            double markersPrice = 7.20;
            double cleaningPrice = 1.20;


            double total = (pens * pensPrice + markers * markersPrice + cleaningPerLiter * cleaningPrice);
            double totalAfterDiscount = total - (total * discount / 100);
            Console.WriteLine($"{totalAfterDiscount:f3}");
        }
    }
}
