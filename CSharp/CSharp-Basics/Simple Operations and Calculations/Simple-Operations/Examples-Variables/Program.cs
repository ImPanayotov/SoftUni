using System;

namespace Examples_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Моля, въведи едно число: ");
            string str = Console.ReadLine();
            int num = int.Parse(str);
            Console.WriteLine("Числото е: " + num);
            int numplusone = num + 1;
            Console.WriteLine("Чичслото + 1 = " + numplusone);
           
          
        }
    }
}
