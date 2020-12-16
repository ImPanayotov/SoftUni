using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int moneyFromBirthdays = 0;
            int moneyGift = 10;

            int toysCount = 0;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 0)
                {
                    moneyFromBirthdays += moneyGift;
                    moneyGift += 10;
                    moneyFromBirthdays -= 1;
                }
                else
                {
                    toysCount++;
                }
            }
            int moneyFromToys = toysCount * toyPrice;
            moneyFromBirthdays += moneyFromToys;

            double diff = Math.Abs(moneyFromBirthdays - washingMachinePrice);

            if (moneyFromBirthdays >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {diff:f2}");
            }
            else
            {
                Console.WriteLine($"No! {diff:f2}");
            }


        }
    }
}
