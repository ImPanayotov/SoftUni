using System;

namespace dogFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int others = int.Parse(Console.ReadLine());
            double total = dogs * 2.5 + others * 4;
            Console.WriteLine($"{total:f2} lv.");
            
        }
    }
}
