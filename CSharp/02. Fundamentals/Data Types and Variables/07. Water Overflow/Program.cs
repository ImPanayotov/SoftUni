using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int capacity = 255;
            int litersPoured = 0;

            for (int i = 0; i < n; i++)
            {
                int qty = int.Parse(Console.ReadLine());
                if (capacity >= qty)
                {
                    capacity -= qty;
                    litersPoured += qty;
                    
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(litersPoured);
        }
    }
}
