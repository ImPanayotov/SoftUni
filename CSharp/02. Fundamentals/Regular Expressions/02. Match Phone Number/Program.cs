using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phonesInputs = Console.ReadLine();
            Regex phonePattern = new Regex(@"\+([359]+)([- ])2(\2)(\d{3})(\2)(\d{4})\b");
            var match = phonePattern.Matches(phonesInputs);
            int phoneNumbersCount = 0;

            foreach (var phoneNumber in match)
            {
                string collection = phoneNumber + ", ";
                phoneNumbersCount += 1;
                if (phoneNumbersCount == match.Count)
                {
                    Console.Write(collection.Remove(collection.Length - 2));
                }
                else
                {
                    Console.Write(collection);
                }
            }
            Console.WriteLine();
        }
    }
}
