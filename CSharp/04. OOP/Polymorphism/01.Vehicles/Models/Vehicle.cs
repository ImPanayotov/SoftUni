using _01.Vehicles.Common;
using _01.Vehicles.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public abstract class Vehicle : IDrivable, IRefuelable
    {
        private const string SUCC_DRIVED_MSG = "{0} travelled {1} km";
        private double fuelQuantity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }


        public double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            private set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }

                this.fuelQuantity = value;
            }
        }

        public virtual double FuelConsumption { get; }

        public double TankCapacity { get; }


        public void Drive(Vehicle vehicle, string vehicleType, double amount)
        {
            double fuelNeeded;

            if (vehicleType == "Bus")
            {
                 fuelNeeded = amount * (this.FuelConsumption + 1.4);
            }
            else
            {
                fuelNeeded = amount * this.FuelConsumption;
            }

            if (this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.NotEnoughFuel, this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;

            Console.WriteLine(string.Format(SUCC_DRIVED_MSG, this.GetType().Name, amount));
        }

        public string DriveEmpty(double amount)
        {
            double fuelNeeded = amount * this.FuelConsumption;

            if (this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.NotEnoughFuel, this.GetType().Name));
            }

            this.FuelQuantity -= fuelNeeded;

            return string.Format(SUCC_DRIVED_MSG, this.GetType().Name, amount);

        }

        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException(ExceptionMessages.NegFuel);
            }
            else if (amount + this.fuelQuantity > TankCapacity)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.TooMuchFuel, amount));
            }

            this.FuelQuantity += amount;

        }


        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }
    }
}
