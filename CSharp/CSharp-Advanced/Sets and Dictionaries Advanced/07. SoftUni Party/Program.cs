using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();
            HashSet<string> vip = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "PARTY")
                {
                    while (true)
                    {
                        string peopleAtParty = Console.ReadLine();

                        if (peopleAtParty == "END")
                        {
                            break;
                        }

                        guests.Remove(peopleAtParty);
                    }
                    break;
                }

                if (input == "END")
                {
                    break;
                }

                if (input.Length == 8)
                {
                    guests.Add(input);
                }
            }

            foreach (var guest in guests)
            {
                if (char.IsDigit(guest[0]))
                {
                    vip.Add(guest);
                }
                else
                {
                    regular.Add(guest);
                }
            }

            Console.WriteLine(guests.Count);

            foreach (var guest in vip)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
