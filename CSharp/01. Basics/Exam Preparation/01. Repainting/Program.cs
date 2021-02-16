using System;

namespace _01._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylonPricePerSqrt = 1.50;
            double paintPricePerL = 14.5;
            double paintDissolvePricePerL = 5.0;
            double bagPrice = 0.40;
            //+ 10% boya; + 2 kv. naylon + 0.40 st torbichki
            // cena za 1 chas maistori = 30% ot vsichki razhodi

            int nylonQuantity = int.Parse(Console.ReadLine());
            int paintQuantity = int.Parse(Console.ReadLine());
            int paintDissolver = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double nylon = (nylonQuantity + 2) * nylonPricePerSqrt;
            double paint = (paintPricePerL * paintQuantity) * 1.10;
            double dissolver = paintDissolvePricePerL * paintDissolver;

            double materials = nylon + paint + dissolver + bagPrice;
            double workers = workHours * (materials * 0.30);
            double total = materials + workers;



            Console.WriteLine($"Total expenses: {total:f2} lv.");

        }
    }
}
