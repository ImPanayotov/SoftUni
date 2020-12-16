using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalLightsabres = Math.Ceiling(studentsCount * 1.1) * lightsaberPrice;
            double totalRobes = studentsCount * 1.0 * robePrice;
            double totalBelts = studentsCount * 1.0 * beltPrice;
            int discount = studentsCount / 6;


            double neededMoney = totalLightsabres + totalRobes + (totalBelts - discount * beltPrice);

            if (neededMoney <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {neededMoney - money:f2}lv more.");
            }
        }
    }
}
