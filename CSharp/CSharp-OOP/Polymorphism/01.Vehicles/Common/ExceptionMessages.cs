using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Common
{
   public static class ExceptionMessages
    {
        public const string NotEnoughFuel = "{0} needs refueling";
        public const string NegFuel = "Fuel must be a positive number";
        public const string InvallidVehicleType = "Invalid vehicle type!";
        public const string TooMuchFuel = "Cannot fit {0} fuel in the tank";

    }
}
