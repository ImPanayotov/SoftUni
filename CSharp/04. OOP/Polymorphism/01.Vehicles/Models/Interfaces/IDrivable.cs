using _01.Vehicles.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Vehicles.Interfaces
{
   public interface IDrivable
    {
        void Drive(Vehicle vehicle, string vehicleType, double amount);
        string DriveEmpty(double amount);
    }
}
