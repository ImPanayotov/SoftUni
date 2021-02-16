using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Models
{
    public class Bus : Vehicle
    {
        //private const double FUEL_CONSUMPTION_INCR = 0.9;
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {

        }

    }
}
