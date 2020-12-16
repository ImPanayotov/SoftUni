using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Tire[]> tires = new List<Tire[]>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "No more tires")
                {
                    break;
                }

                string[] splitted = input.Split();

                int firstTireYear = int.Parse(splitted[0]);
                double firstTirePressure = double.Parse(splitted[1]);

                int secondTireYear = int.Parse(splitted[2]);
                double secondTirePressure = double.Parse(splitted[3]);

                int thirdTireYear = int.Parse(splitted[4]);
                double thirdTirePressure = double.Parse(splitted[5]);

                int fourthTireYear = int.Parse(splitted[6]);
                double fourthTirePressure = double.Parse(splitted[7]);

                Tire[] currentTires = new Tire[4]
                {
                    new Tire(firstTireYear, firstTirePressure),
                    new Tire(secondTireYear, secondTirePressure),
                    new Tire(thirdTireYear, thirdTirePressure),
                    new Tire(fourthTireYear, fourthTirePressure),
                };

                tires.Add(currentTires);
            }

            List<Engine> engines = new List<Engine>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }

                string[] splitted = input.Split();

                int horsePower = int.Parse(splitted[0]);
                double cubicCapacity = double.Parse(splitted[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Show special")
                {
                    break;
                }

                string[] splitted = input.Split();

                string make = splitted[0];
                string model = splitted[1];
                int year = int.Parse(splitted[2]);
                double fuelQuantity = double.Parse(splitted[3]);
                double fuelConsumption = double.Parse(splitted[4]);
                int engineIndex = int.Parse(splitted[5]);
                int tiresIndex = int.Parse(splitted[6]);

                if ((engineIndex >= 0 && engineIndex < engines.Count) && (tiresIndex >= 0 && tiresIndex < tires.Count))
                {
                    Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tiresIndex]);
                    cars.Add(car);
                }
            }

            cars = cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}
