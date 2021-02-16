using System;

namespace _00._ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            string pin = "1234";
            double balance = 100000;

            int counter = 0;
            string input = Console.ReadLine();

            bool checkIfIncorrect = false;

            while (input != pin)
            {
                counter++;
                if (counter == 3)
                {
                    Console.WriteLine("Try again tomorrow");
                    break;
                }

                Console.WriteLine("Invalid PIN! Try again");
                input = Console.ReadLine();
            }
            if (pin == input)
            {
                Console.WriteLine("Enter amount:");
                int amount = int.Parse(Console.ReadLine());
                
                if (amount <= balance)
                {
                    if (amount % 10 == 0)
                    {
                        balance -= amount;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect amount");
                        checkIfIncorrect = true;
                    }
                }
                if (!checkIfIncorrect)
                {
                    Console.WriteLine("Would you like a recipt?");
                    string answer = Console.ReadLine();

                    if (answer == "yes")
                    {
                        Console.WriteLine("You have " + balance + "lv. left");
                    }
                }
            
            }
        }
    }
}
