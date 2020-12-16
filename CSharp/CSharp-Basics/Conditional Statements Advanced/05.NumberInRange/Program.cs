using System;

namespace _05.NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която проверява дали въведеното от потребителя число е в интервала[-100, 100]
            //и е различно от 0 и извежда "Yes", ако отговаря на условията, или "No" ако е извън тях.
            //Примерен вход и изход
            //вход изход       вход изход       вход изход
            //-25 Yes     0   No      25  Yes
            double num = double.Parse(Console.ReadLine());
            if (num >= -100 && num != 0 && num <= 100)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
