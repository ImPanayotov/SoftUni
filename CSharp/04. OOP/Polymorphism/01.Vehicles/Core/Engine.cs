using _01.Vehicles.Common;
using _01.Vehicles.Core.Interfaces;
using _01.Vehicles.Factories;
using _01.Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Vehicles.Core
{
    public class Engine : IEngine
    {

        private readonly Vehicle car;
        private readonly Vehicle truck;
        private readonly Vehicle bus;

        private readonly VehicleFactory vehicleFactory;

        public Engine()
        {
            this.vehicleFactory = new VehicleFactory();
        }


        public void Run()
        {
            Vehicle car = this.ProcessVehicleInfo();
            Vehicle truck = this.ProcessVehicleInfo();
            Vehicle bus = this.ProcessVehicleInfo();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split().ToArray();

                string cmdType = cmdArgs[0];
                string vehicleType = cmdArgs[1];
                double arg = double.Parse(cmdArgs[2]);

                try
                {
                    if (cmdType == "Drive")
                    {
                        if (vehicleType == "Car")
                        {
                            this.Drive(vehicleType, car, arg);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.Drive(vehicleType, truck, arg);
                        }
                        else if (vehicleType == "Bus")
                        {
                            this.Drive(vehicleType, bus, arg);
                        }
                    }
                    else if (cmdType == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            this.Refuel(car, arg);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.Refuel(truck, arg);
                        }
                        else if (vehicleType == "Bus")
                        {
                            this.Refuel(bus, arg);
                        }
                    }
                    else if (cmdType == "DriveEmpty")
                    {
                        if (vehicleType == "Car")
                        {
                            this.DriveEmpty(car, arg);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.DriveEmpty(truck, arg);
                        }
                        else if (vehicleType == "Bus")
                        {
                            this.DriveEmpty(bus, arg);
                        }
                    }

                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
        private void Refuel(Vehicle vehicle, double amount)
        {
            vehicle.Refuel(amount);
        }

        private void Drive(string vehicleType, Vehicle vehicle, double kilometers)
        {
            vehicle.Drive(vehicle, vehicleType, kilometers);
        }

        private void DriveEmpty(Vehicle vehicle, double kilometers)
        {
            vehicle.DriveEmpty(kilometers);
        }

        private Vehicle ProcessVehicleInfo()
        {
            string[] vehicleArgs = Console.ReadLine().Split().ToArray();

            string vehicleType = vehicleArgs[0];
            double fuelQuantity = double.Parse(vehicleArgs[1]);
            double fuelConsumption = double.Parse(vehicleArgs[2]);
            double tankCapacity = double.Parse(vehicleArgs[3]);

            Vehicle currentVehicle = this.vehicleFactory.CreateVehicle(vehicleType, fuelQuantity, fuelConsumption, tankCapacity);

            return currentVehicle;
        }
    }
}
