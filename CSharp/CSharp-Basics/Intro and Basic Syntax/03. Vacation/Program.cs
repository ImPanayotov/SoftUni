using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal groupOfPeople = decimal.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string weekDay = Console.ReadLine();
            decimal price = 0M;

            if (typeOfGroup == "Students")
            {
                switch (weekDay)
                {
                    case "Friday": price = 8.45M; break;
                    case "Saturday": price = 9.80M; break;
                    case "Sunday": price = 10.46M; break;
                }
                //if (groupOfPeople >= 30)
                //{
                //    Console.WriteLine($"Total price: {(groupOfPeople * price) * 0.85:f2}");
                //}
                //else
                //{
                //    Console.WriteLine($"Total price: {groupOfPeople * price:f2}");
                //}
            }
            else if (typeOfGroup == "Business")
            {
                switch (weekDay)
                {
                    case "Friday": price = 10.90M; break;
                    case "Saturday": price = 15.60M; break;
                    case "Sunday": price = 16M; break;
                }
                //if (groupOfPeople >= 100)
                //{
                //    Console.WriteLine($"Total price: {(groupOfPeople * price) - (groupOfPeople * 10):f2}");
                //}
                //else
                //{
                //    Console.WriteLine($"Total price: {groupOfPeople * price:f2}");
                //}
            }
            else if (typeOfGroup == "Regular")
            {
                switch (weekDay)
                {
                    case "Friday": price = 15M; break;
                    case "Saturday": price = 20M; break;
                    case "Sunday": price = 22.50M; break;
                }
                //if (groupOfPeople >= 10 && groupOfPeople <= 20)
                //{
                //    Console.WriteLine($"Total price: {(groupOfPeople * price) * 0.95:f2}");
                //}
                //else
                //{
                //    Console.WriteLine($"Total price: {groupOfPeople * price:f2}");
                //}
            }
            if (typeOfGroup == "Students" && groupOfPeople >= 30)
            {
                Console.WriteLine($"Total price: {groupOfPeople * price * 0.85M:f2}");
            }
            else if (typeOfGroup == "Business" && groupOfPeople >= 100)
            {
                Console.WriteLine($"Total price: {(groupOfPeople * price) - (groupOfPeople * 10M):f2}");
            }
            else if (typeOfGroup == "Regular" && groupOfPeople >= 10 && groupOfPeople <= 20)
            {
                Console.WriteLine($"Total price: {groupOfPeople * price * 0.95M:f2}");
            }
            else
            {
                Console.WriteLine($"Total price: {groupOfPeople * price:f2}");
            }
        }
    }
}
