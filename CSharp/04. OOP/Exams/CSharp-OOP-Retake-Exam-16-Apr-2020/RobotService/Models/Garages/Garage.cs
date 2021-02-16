using RobotService.Models.Garages.Contracts;
using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotService.Models.Garages
{

    public  class Garage : IGarage
    {
        private readonly Dictionary<string, IRobot> robots;


        public Garage()
        {
            robots = new Dictionary<string, IRobot>();
        }

        public IReadOnlyDictionary<string, IRobot> Robots => robots;

        public int Capacity { get; set; } = 10;
        public void Manufacture(IRobot robot)
        {
            if (robots.Count >= Capacity)
            {
                throw new InvalidOperationException("Not enough capacity");
            }

            if (robots.ContainsKey(robot.Name))
            {
                throw new ArgumentException($"Robot {robot.Name} already exist");
            }

            robots.Add(robot.Name, robot);
        }

        public void Sell(string robotName, string ownerName)
        {
            if (!robots.ContainsKey(robotName))
            {
                throw new ArgumentException($"Robot {robotName} does not exist");
            }
            //If a robot with that name exists, change its owner, its bought status and remove the robot from the garage.
            var robot = robots.FirstOrDefault(r => r.Key == robotName);
            robot.Value.Owner = ownerName;
            robot.Value.IsBought = true;
            robots.Remove(robotName);

        }
    }
}
