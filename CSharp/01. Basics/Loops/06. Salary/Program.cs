using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int tab = 1; tab <= tabs; tab++)
            {
                string name = Console.ReadLine();

                switch (name)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
