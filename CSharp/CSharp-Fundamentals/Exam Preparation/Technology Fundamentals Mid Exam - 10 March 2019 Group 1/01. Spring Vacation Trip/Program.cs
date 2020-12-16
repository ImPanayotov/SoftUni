using System;

namespace _01._Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            decimal pricePerKM = decimal.Parse(Console.ReadLine());
            decimal foodExpenses = decimal.Parse(Console.ReadLine());
            decimal priceForRoom = decimal.Parse(Console.ReadLine());

            decimal totalFoodExpenses = days * people * foodExpenses;
            decimal totalHotelExpenses = days * people * priceForRoom;
            if (people > 10)
            {
                totalHotelExpenses *= 0.75m;
            }
            decimal totalExpenses = totalFoodExpenses + totalHotelExpenses;



            for (int i = 1; i <= days; i++)
            {
                decimal travelledKM = decimal.Parse(Console.ReadLine());
                totalExpenses += travelledKM * pricePerKM;
                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalExpenses *= 1.4m;
                }
                if (i % 7 == 0)
                {
                    totalExpenses -= totalExpenses / people;
                }
                if (totalExpenses > budget)
                {
                    decimal neededMoney = totalExpenses - budget;
                    Console.WriteLine($"Not enough money to continue the trip. You need {neededMoney:f2}$ more.");
                    return;
                }
            }
            decimal budgetLeft = budget - totalExpenses;
            Console.WriteLine($"You have reached the destination. You have {budgetLeft:f2}$ budget left.");

            

        }
    }
}
