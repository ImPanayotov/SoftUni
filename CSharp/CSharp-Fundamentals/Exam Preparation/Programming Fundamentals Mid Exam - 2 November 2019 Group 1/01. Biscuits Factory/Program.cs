using System;

namespace _01._Biscuits_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorker = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int otherfactoryBiscuits = int.Parse(Console.ReadLine());

            int totalCount = 0;

            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    if (biscuitsPerWorker != 1)
                    {
                        totalCount += (int)(0.75 * biscuitsPerWorker * countOfWorkers);
                    }
                }
                else
                {
                    totalCount += biscuitsPerWorker * countOfWorkers;
                }
            }
            Console.WriteLine($"You have produced {totalCount} biscuits for the past month.");
            int diff = totalCount - otherfactoryBiscuits;
            decimal percent = diff / (decimal)otherfactoryBiscuits * 100;
            string sign = "more";
            if (percent < 0)
            {
                percent *= -1;
                sign = "less";
            }
            Console.WriteLine($"You produce {percent:f2} percent {sign} biscuits.");

        }
    }
}

