using EasterRaces.Core.Contracts;
using EasterRaces.Models.Drivers.Entities;
using EasterRaces.Models.Cars.Contracts;
using EasterRaces.Models.Cars.Entities;
using EasterRaces.Models.Races.Entities;
using EasterRaces.Models.Drivers.Contracts;
using EasterRaces.Models.Races.Contracts;
using EasterRaces.Repositories.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace EasterRaces.Core.Entities
{
    public class ChampionshipController : IChampionshipController
    {
        private DriverRepository drivers;
        private CarRepository cars;
        private RaceRepository races;

        public ChampionshipController()
        {
            drivers = new DriverRepository();
            cars = new CarRepository();
            races = new RaceRepository();
        }

        public string AddCarToDriver(string driverName, string carModel)
        {
            if (!drivers.GetAll().Any(x => x.Name == driverName))
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }

            if (!cars.GetAll().Any(x => x.Model == carModel))
            {
                throw new InvalidOperationException($"Car {carModel} could not be found.");
            }

            var car = cars.GetAll().FirstOrDefault(x => x.Model == carModel);
            var driver = drivers.GetAll().FirstOrDefault(x => x.Name == driverName);
            driver.AddCar(car);

            return $"Driver {driverName} received car {carModel}.";
        }

        public string AddDriverToRace(string raceName, string driverName)
        {
            if (!races.GetAll().Any(x => x.Name == raceName))
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            if (!drivers.GetAll().Any(x => x.Name == driverName))
            {
                throw new InvalidOperationException($"Driver {driverName} could not be found.");
            }

            var driver = drivers.GetAll().FirstOrDefault(x => x.Name == driverName);
            var race = races.GetAll().FirstOrDefault(x => x.Name == raceName);
            race.AddDriver(driver);

            return $"Driver {driverName} added in {raceName} race.";
        }

        public string CreateCar(string type, string model, int horsePower)
        {
            if (cars.GetAll().Any(x => x.Model == model))
            {
                throw new ArgumentException($"Car {model} is already created.");
            } 

            ICar car = null;

            if (type == "Muscle")
            {
                car = new MuscleCar(model, horsePower);
            }
            else if (type == "Sports")
            {
                car = new SportsCar(model, horsePower);
            }

            cars.Add(car);

            return $"{car.GetType().Name} {model} is created.";
        }

        public string CreateDriver(string driverName)
        {
            if (drivers.GetAll().Any(x => x.Name == driverName))
            {
                throw new ArgumentException($"Driver {driverName} is already created.");
            }

            drivers.Add(new Driver(driverName));

            return $"Driver {driverName} is created.";
        }

        public string CreateRace(string name, int laps)
        {

            if (races.GetAll().Any(x => x.Name == name))
            {
                throw new InvalidOperationException($"Race {name} is already create.");
            }

            var race = new Race(name, laps);
            races.Add(race);

            return $"Race {name} is created.";
        }

        public string StartRace(string raceName)
        {
            if (!races.GetAll().Any(x => x.Name == raceName))
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            IRace race = this.races.GetAll().FirstOrDefault(r => r.Name == raceName);

            if (race.Drivers.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            List<IDriver> driversInRace = race.Drivers.ToList().OrderByDescending(d => d.Car.CalculateRacePoints(race.Laps)).Take(3).ToList();

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < driversInRace.Count; i++)
            {
                IDriver driver = driversInRace[i];

                if (i == 0)
                {
                    result.AppendLine($"Driver {driver.Name} wins {raceName} race.");

                }
                else if (i == 1)
                {
                    result.AppendLine($"Driver {driver.Name} is second in {raceName} race.");

                }
                else if (i == 2)
                {
                    result.AppendLine($"Driver {driver.Name} is third in {raceName} race.");

                }
            }

            races.Remove(race);
            return result.ToString().Trim();
        }
    }
}
