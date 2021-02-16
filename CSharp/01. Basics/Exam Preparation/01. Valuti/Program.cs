using System;

namespace _01._Valuti
{
    class Program
    {
        static void Main(string[] args)
        {
            double bitcoins = double.Parse(Console.ReadLine()) * 1168;
            double yuan = double.Parse(Console.ReadLine()) * 0.15 * 1.76;
            double commission = double.Parse(Console.ReadLine()) / 100;

            double bitcoinsToEur = bitcoins / 1.95;
            double yuanToEur = yuan / 1.95;

            Console.WriteLine((bitcoinsToEur + yuanToEur) - ((bitcoinsToEur + yuanToEur) * commission));
        }
    }
}
