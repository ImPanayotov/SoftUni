using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            var catalog = new CatalogVehicle();
            catalog.trucks = new List<Truck>();
            catalog.cars = new List<Car>();

            while (true)
            {
                List<string> input = Console.ReadLine().Split("/").ToList();

                if (input[0] == "end")
                {
                    break;
                }

                if (input[0] == "Truck")
                {
                    Truck truck = new Truck();
                    truck.Brand = input[1];
                    truck.Model = input[2];
                    truck.Weight = input[3];
                    catalog.trucks.Add(truck);
                }
                else if (input[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = input[1];
                    car.Model = input[2];
                    car.HorsePower = input[3];
                    catalog.cars.Add(car);
                }
            }

            if (catalog.cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.trucks.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class CatalogVehicle
    {
        public List<Car> cars { get; set; }
        public List<Truck> trucks { get; set; }
    }

    class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string HorsePower { get; set; }
    }

    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public string Weight { get; set; }
    }
}
