using System;

namespace _03._fitness_card
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            char gander = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double totalMoney = 0;

            if ((age >= 5 && age <= 105) && (money >= 10 && money < 1000))
            {
                //Пол   Gym Boxing  Yoga  Zumba Dances  Pilates
                //мъж    $42  $41    $45    $34   $51      $39
                if (gander == 'm')
                {
                    switch (sport)
                    {
                        case "Gym":
                            totalMoney = 42;
                            break;
                        case "Boxing":
                            totalMoney = 41;
                            break;
                        case "Yoga":
                            totalMoney = 45;
                            break;
                        case "Zumba":
                            totalMoney = 34;
                            break;
                        case "Dances":
                            totalMoney = 51;
                            break;
                        case "Pilates":
                            totalMoney = 39;
                            break;
                    }
                }
                //Пол   Gym Boxing  Yoga  Zumba Dances  Pilates
                //жена  $35  $37    $42    $31   $53      $37
                else if (gander == 'f')
                {
                    switch (sport)
                    {
                        case "Gym":
                            totalMoney = 35;
                            break;
                        case "Boxing":
                            totalMoney = 37;
                            break;
                        case "Yoga":
                            totalMoney = 42;
                            break;
                        case "Zumba":
                            totalMoney = 31;
                            break;
                        case "Dances":
                            totalMoney = 53;
                            break;
                        case "Pilates":
                            totalMoney = 37;
                            break;
                    }
                }
                if (age <= 19)
                {
                    totalMoney -= totalMoney * 0.2;
                }
                if (totalMoney <= money)
                {
                    Console.WriteLine($"You purchased a 1 month pass for {sport}.");
                }
                else
                {
                    Console.WriteLine("You don't have enough money! You need ${0:f2} more.", totalMoney - money);
                }
            }
        }
    }
}
