using System;

namespace _05._Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int counter = 0;
            // STOP change <= 0
            // Produlzhavame -> change > 0
            // 1.23lv -> 123 st
            double changeInSt = Math.Floor(change * 100); // prevryshtame v stotinki
            while (changeInSt > 0)
            {
                //2, 1, 50 st, 20 st, 10 st, 5 st, 2 st, 1 st
                //1.23 
                //2.23 -> 
                if (changeInSt >= 200)
                {
                    changeInSt -= 200;
                    counter++;
                }
                else if (changeInSt >= 100)
                {
                    changeInSt -= 100;
                    counter++;
                }
                else if (changeInSt >= 50)
                {
                    changeInSt -= 50;
                    counter++;
                }
                else if (changeInSt >= 20)
                {
                    changeInSt -= 20;
                    counter++;
                }
                else if (changeInSt >= 10)
                {
                    changeInSt -= 10;
                    counter++;
                }
                else if (changeInSt >= 5)
                {
                    changeInSt -= 5;
                    counter++;
                }
                else if (changeInSt >= 2)
                {
                    changeInSt -= 2;
                    counter++;
                }
                else if (changeInSt >= 1)
                {
                    changeInSt -= 1;
                    counter++;
                }
                
            }
            Console.WriteLine(counter);
        }
    }
}
