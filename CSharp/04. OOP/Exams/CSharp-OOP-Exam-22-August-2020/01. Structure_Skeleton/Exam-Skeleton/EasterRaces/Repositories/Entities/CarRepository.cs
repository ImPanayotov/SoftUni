using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Repositories.Entities
{
    public class CarRepository : Repository<ICar>
    {
        private readonly List<ICar> cars;

        public CarRepository()
        {
            cars = new List<ICar>();
        }
    }
}
