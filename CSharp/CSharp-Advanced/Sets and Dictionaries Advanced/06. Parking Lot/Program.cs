using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");

                if (input[0] == "END")
                {
                    break;
                }

                string direction = input[0];
                string carNumber = input[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carNumber);
                }
                else
                {
                    parkingLot.Remove(carNumber);
                }
            }

            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
