using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = "";
            string input = "";
            int length = user.Length - 1;
            


            while (length >= 0)
            {
              pass += user[length];
                length--;
            }

            input = Console.ReadLine();

            for (int i = 0; i <= 3; i++)
            {
                if (i == 3)
                {
                    if (input == pass)
                    {
                        Console.WriteLine("User {0} logged in.", user);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("User {0} blocked!", user);
                    }
                }
                else if (input == pass)
                {
                    Console.WriteLine("User {0} logged in.", user);
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    input = Console.ReadLine();
                }


            }
            }
    }
}
