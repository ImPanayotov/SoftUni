using System;

namespace _07.InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дадено число е валидно, ако е в диапазона[100…200] или е 0.Да се напише програма, която чете цяло число,
            //въведено от потребителя, и печата "invalid" ако въведеното число не е валидно. 

            //Примерен вход и изход
            //вход изход       вход изход       вход изход       вход изход
            //75  invalid     150(няма изход)        220 invalid     199(няма изход)

            //вход изход       вход изход       вход изход       вход изход
            //-1  invalid     100(няма изход)        200(няма изход)        0(няма изход)
            double num = double.Parse(Console.ReadLine());
            if (num >= 100 && num <= 200)
            {
                
            }
            else if (num == 0)
            {
            
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
