using System;

namespace _05._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int asciiCode = 96;

            for (int i = 1; i <= n;  i++)
            {
                for (int j = 1; j <=n; j++)
                {
                    for (char k = 'a' ; k <= asciiCode + l; k++)
                    {
                        for (char m = 'a'; m <= asciiCode + l; m++)
                        {
                            for (int x = 1; x <= n; x++)
                            {
                                if (x > i && x > j)
                                {
                                    Console.Write($"{i}{j}{k}{m}{x} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
