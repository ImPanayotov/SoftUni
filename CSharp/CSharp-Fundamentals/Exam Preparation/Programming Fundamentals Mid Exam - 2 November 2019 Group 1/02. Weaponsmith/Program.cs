using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] particles = Console.ReadLine()
                .Split("|")
                .ToArray();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "Done")
                {
                    break;
                }
                if (command[0] == "Check")
                {
                    int sign = 0;

                    if (command[1] == "Odd")
                    {
                        sign = 1;
                    }

                    for (int i = 0; i < particles.Length; i++)
                    {
                        if (i % 2 == sign)
                        {
                            Console.Write(particles[i] + " ");
                        }
                    }

                    Console.WriteLine();
                }

                if (command[0] == "Move")
                {

                    if (command[1] == "Left")
                    {
                        MoveLeft(particles, int.Parse(command[2]));
                    }
                    if (command[1] == "Right")
                    {
                        MoveRight(particles, int.Parse(command[2]));
                    }
                }
            }

            Console.WriteLine($"You crafted " + string.Join("", particles) + "!");
        }

        public static string[] MoveLeft(string[] particles, int index)
        {
            if (index > 0 && index < particles.Length)
            {

                string temp = particles[index];
                particles[index] = particles[index - 1];
                particles[index - 1] = temp;
            }


            return particles;
        }

        public static string[] MoveRight(string[] particles, int index)
        {
            if (index >= 0 && index < particles.Length - 1)
            {
                string temp = particles[index];
                particles[index] = particles[index + 1];
                particles[index + 1] = temp;
            }

            return particles;
        }

        public static void CheckEven(string[] particles)
        {
            for (int i = 0; i < particles.Length; i++)
            {

                if (i % 2 == 0)
                {
                    Console.Write(particles[i] + " ");
                }
            }
            Console.WriteLine();
        }

        public static void CheckOdd(string[] particles)
        {
            for (int i = 0; i < particles.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(particles[i] + " ");

                }
            }
            Console.WriteLine();
        }
    }
}
