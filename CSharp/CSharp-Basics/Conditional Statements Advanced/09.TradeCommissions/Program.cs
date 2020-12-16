using System;

namespace _09.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double com = 0.0;

            if (city == "Sofia")
            {
                if (sales > 0 && sales <= 500)
                {
                    com = 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    com = 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    com = 0.08;
                }
                else if (sales > 10000)
                {
                    com = 0.12;
                }
            }
            if (city == "Plovdiv")
            {
                if (sales > 0 && sales <= 500)
                {
                    com = 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    com = 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    com = 0.12;
                }
                else if (sales > 10000)
                {
                    com = 0.145;
                }
            }
            if (city == "Varna")
            {
                if (sales > 0 && sales <= 500)
                {
                    com = 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    com = 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    com = 0.10;
                }
                else if (sales > 10000)
                {
                    com = 0.13;
                }
            }
            if (com > 0)
            {
                Console.WriteLine($"{com * sales:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
            
        }
    }
}
