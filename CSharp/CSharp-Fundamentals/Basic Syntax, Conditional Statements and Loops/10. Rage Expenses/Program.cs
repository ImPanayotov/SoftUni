using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = lostGamesCount / 2;
            int trashedMouse = lostGamesCount / 3;
            int trashedKeyboard = lostGamesCount / 6;
            int trashedDisplay = lostGamesCount / 12;

            double headsetExpenses = headsetPrice * trashedHeadset;
            double mouseExpenses = mousePrice * trashedMouse;
            double keyboardExpenses = keyboardPrice * trashedKeyboard;
            double displayExpenses = displayPrice * trashedDisplay;
            double totalExpenses = headsetExpenses + mouseExpenses + keyboardExpenses + displayExpenses;
            
            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");

        }
    }
}
