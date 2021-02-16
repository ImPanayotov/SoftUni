using System;

namespace _03.SpeedInfoEX
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            //При скорост до 10(включително) отпечатайте “slow”. 
            //При скорост над 10 и до 50 отпечатайте “average”.
            //При скорост над 50 и до 150 отпечатайте “fast”. 
            //При скорост над 150 и до 1000 отпечатайте “ultra fast”. 
            //    При по-висока скорост отпечатайте “extremely fast”
            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            if (speed > 10 && speed <= 50)
            {
                Console.WriteLine("average");
            }
            if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            if (speed > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
