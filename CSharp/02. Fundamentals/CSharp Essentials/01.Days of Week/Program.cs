using System;
using System.Linq;

namespace Days_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[]
            {
                "Monday" ,
                "Tuesday" ,
                "Wednesday" ,
                "Thursday" ,
                "Friday" ,
                "Saturday",
                "Sunday"
            };
            int input = int.Parse(Console.ReadLine());

            if (input < 1 || input > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(days[input - 1]);
            }

            //string[] daysOfWeek = new string[]
            //{
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "Thrsday",
            //    "Friday",
            //    "Saturday",
            //    "Sunday"

            //};

            //Console.WriteLine("What day you want? (1-7):");
            //int daysNumber = int.Parse(Console.ReadLine());
            //while (daysNumber < 1 && daysNumber > 7)
            //{
            //    Console.WriteLine("Zashto?");
            //    Console.WriteLine("Opitai pak!");
            //    daysNumber = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("The day is: " + daysOfWeek[daysNumber-1]);
            // daysOfWeek[0] = "Monday";

            //int n = int.Parse(Console.ReadLine());

            //string[] names = new string[n];
            //for (int i = 0; i < names.Length; i++)
            //{
            //    names[i] = Console.ReadLine();

            //}
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}


            //int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine($"Array[{i}]={numbers[i]}");
            //}



        }
    }
}
