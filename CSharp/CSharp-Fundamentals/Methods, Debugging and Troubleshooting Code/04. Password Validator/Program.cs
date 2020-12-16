using System;
using System.ComponentModel.DataAnnotations;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            PrintResult(password);
        }

        public static string CheckLength(string password)
        {
            string str = string.Empty;
            if (password.Length >= 6 && password.Length <= 10)
            {
                str = "isValid";
            }
            return str;
        }
        public static string CheckLettersAndDigits(string password)
        {
            int sumOfChars = 0;
            int length = password.Length;
            string str = string.Empty;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 65 && password[i] <= 90) || (password[i] >= 97 && password[i] <= 122))
                {
                    sumOfChars++;
                }
                else if ((password[i] >= 48 && password[i] <= 57))
                {
                    sumOfChars++;
                }
            }
            if (sumOfChars == length)
            {
                str = "isValid";
            }
            
            return str;
        }
        public static string CheckIfThereAreTwoNumbers(string password)
        {
            int digitsCount = 0;
            string str = string.Empty;
            for (int i = 0; i < password.Length; i++)
            {
                if ((password[i] >= 48 && password[i] <= 57))
                {
                    digitsCount++;
                }
            }

            if (digitsCount >= 2)
            {
                str = "isValid";
            }
            
            return str;
        }
        public static void PrintResult(string password)
        {
            if (CheckLength(password) == "isValid" && CheckLettersAndDigits(password) == "isValid" && CheckIfThereAreTwoNumbers(password) == "isValid")
            {
                Console.WriteLine("Password is valid");
            }
            if (CheckLength(password) != "isValid")
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (CheckLettersAndDigits(password) != "isValid")
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (CheckIfThereAreTwoNumbers(password) != "isValid")
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}
