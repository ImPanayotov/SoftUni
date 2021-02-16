using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            
            double musala = 0;
            double montblanc = 0;
            double kilimanjaro = 0;
            double k2 = 0;
            double everest = 0;
            int peopleCount = 0;

            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());

                if (people <= 5)
                {
                    musala += people;
                    peopleCount += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    montblanc += people;
                    peopleCount += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    kilimanjaro += people;
                    peopleCount += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    k2 += people;
                    peopleCount += people;
                }
                else if (people >= 41)
                {
                    everest += people;
                    peopleCount += people;
                }
            
            }
            Console.WriteLine($"{(musala / peopleCount * 100):f2}%");
            Console.WriteLine($"{(montblanc / peopleCount * 100):f2}%");
            Console.WriteLine($"{(kilimanjaro / peopleCount * 100):f2}%");
            Console.WriteLine($"{(k2 / peopleCount * 100):f2}%");
            Console.WriteLine($"{(everest / peopleCount * 100):f2}%");
            















        }
    }
}
