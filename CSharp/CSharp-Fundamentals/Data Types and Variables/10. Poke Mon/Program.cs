using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Poke Power = N - integer
            //Distance between targets = M - integer
            //exhaustionFactor Y – an integer
            //substract M from N until N is less than M
            // When substract - targetCount +1
            // If N = 50% of original N -> N/Y (if it's possible)
            //else substract M from N
            //after dividing continou substracting M from N until N is lessthan M
            // after that, take what is left from N and targetCount == output

            int nPower = int.Parse(Console.ReadLine());
            int mDistance = int.Parse(Console.ReadLine());
            int yExhaustionFactor = int.Parse(Console.ReadLine());
            int successfullPokes = 0;
            int originalPower = nPower;

            while (nPower >= mDistance)
            {
                nPower -= mDistance;
                successfullPokes++;

                if (nPower == originalPower / 2 && yExhaustionFactor != 0)
                {
                        nPower /= yExhaustionFactor;
                }
            }

            Console.WriteLine(nPower);
            Console.WriteLine(successfullPokes);
        }
    }
}
