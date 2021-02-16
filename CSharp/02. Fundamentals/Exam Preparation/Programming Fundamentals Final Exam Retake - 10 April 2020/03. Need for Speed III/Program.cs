using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<int>>> cars =
                new Dictionary<string, Dictionary<string, List<int>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('|').ToArray();

                string carName = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                cars.Add(carName, new Dictionary<string, List<int>>());

                cars[carName].Add("Mileage", new List<int>());
                cars[carName].Add("Fuel", new List<int>());

                cars[carName]["Mileage"].Add(mileage);
                cars[carName]["Fuel"].Add(fuel);
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ").ToArray();

                string cmd = input[0];

                if (cmd == "Stop")
                {
                    break;
                }

                if (cmd == "Drive")
                {
                    string carName = input[1];
                    int distance = int.Parse(input[2]);
                    int neededFuel = int.Parse(input[3]);

                    if (neededFuel > cars[carName]["Fuel"][0])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[carName]["Fuel"][0] -= neededFuel;
                        cars[carName]["Mileage"][0] += distance;

                        Console.WriteLine($"{carName} driven for {distance} kilometers. {neededFuel} liters of fuel consumed.");

                        if (cars[carName]["Mileage"][0] >= 100000)
                        {
                            cars.Remove(carName);
                            Console.WriteLine($"Time to sell the {carName}!");
                        }
                    }
                }
                else if (cmd == "Refuel")
                {
                    string carName = input[1];
                    int refill = int.Parse(input[2]);

                    if (refill + cars[carName]["Fuel"][0] > 75)
                    {
                        Console.WriteLine($"{carName} refueled with {75 - cars[carName]["Fuel"][0]} liters");

                        cars[carName]["Fuel"][0] = 75;
                    }
                    else
                    {
                        cars[carName]["Fuel"][0] += refill;

                        Console.WriteLine($"{carName} refueled with {refill} liters");
                    }
                }
                else if (cmd == "Revert")
                {
                    string carName = input[1];
                    int kilometers = int.Parse(input[2]);

                    cars[carName]["Mileage"][0] -= kilometers;

                    if (cars[carName]["Mileage"][0] < 10000)
                    {
                        cars[carName]["Mileage"][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                }
            }

            foreach (var car in cars
                .OrderByDescending(x => x.Value["Mileage"][0])
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value["Mileage"][0]} kms, Fuel in the tank: {car.Value["Fuel"][0]} lt.");
            }
        }
    }
}
