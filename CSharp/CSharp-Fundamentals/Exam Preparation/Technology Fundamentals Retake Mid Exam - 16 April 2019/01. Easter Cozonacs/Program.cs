using System;

namespace _01._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal priceForOneKgFloor = decimal.Parse(Console.ReadLine());

            decimal priceForOnePackEggs = priceForOneKgFloor * 0.75m;
            decimal priceForOneLiterMilk = priceForOneKgFloor * 1.25m;
            decimal priceForOneCozonac = priceForOneKgFloor + priceForOnePackEggs + (priceForOneLiterMilk / 4);

            int eggs = 0;
            int cozonacs = 0;

            while (budget > priceForOneCozonac)
            {
                budget -= priceForOneCozonac;
                cozonacs++;
                eggs += 3;

                if (cozonacs % 3 == 0)
                {
                    eggs -= cozonacs - 2;
                }
            }

            Console.WriteLine($"You made {cozonacs} cozonacs! Now you have {eggs} eggs and {budget:f2}BGN left.");
        }
    }
}
