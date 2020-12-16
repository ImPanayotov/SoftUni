using RobotService.Models.Garages;
using RobotService.Models.Procedures;
using RobotService.Models.Robots;
using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotService.Core.Contracts
{
    public class Controller : IController
    {
        private Garage garage;

        public Controller()
        {
            garage = new Garage();
        }
        public string Charge(string robotName, int procedureTime)
        {
            DoesRobotExists(robotName);

            var robot = garage.Robots.Values.FirstOrDefault(r => r.Name == robotName);
            Charge charge = new Charge();
            charge.DoService(robot, procedureTime);

            return $"{robotName} had charge procedure";
        }

        public string Chip(string robotName, int procedureTime)
        {
            DoesRobotExists(robotName);

            var robot = garage.Robots.FirstOrDefault(r => r.Value.Name == robotName);
            Chip chip = new Chip();
            chip.DoService(robot.Value, procedureTime);
            
            return $"{robotName} had chip procedure";
        }

        private void DoesRobotExists(string robotName)
        {
            if (!garage.Robots.ContainsKey(robotName))
            {
                throw new ArgumentException($"Robot {robotName} does not exist");
            }
            
        }

        public string History(string procedureType) //dont check
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"{procedureType}");

            if (procedureType == "Chip")
            {
                foreach (var robot in garage.Robots.TakeWhile(proc => proc.Value.IsChipped))
                {
                    output.AppendLine(robot.ToString());
                }
            }
            else if (procedureType == "TechCheck")
            {
                foreach (var robot in garage.Robots.TakeWhile(proc => proc.Value.IsChecked))
                {
                    output.AppendLine(robot.ToString());
                }
            }

            return output.ToString().Trim();
        }

        public string Manufacture(string robotType, string name, int energy, int happiness, int procedureTime) //dont check
        {
            IRobot robot = null;

            if (robotType == "HouseholdRobot")
            {
                robot = new HouseholdRobot(name, energy, happiness, procedureTime);
            }
            else if (robotType == "PetRobot")
            {
                robot = new PetRobot(name, energy, happiness, procedureTime);
            }
            else if (robotType == "WalkerRobot")
            {
                robot = new WalkerRobot(name, energy, happiness, procedureTime);
            }
            else
            {
                throw new ArgumentException($"{robotType} type doesn't exist");
            }

            garage.Manufacture(robot);

            return $"Robot {name} registered successfully";
        }

        public string Polish(string robotName, int procedureTime)
        {
            DoesRobotExists(robotName);

            var robot = garage.Robots.Values.FirstOrDefault(r => r.Name == robotName);
            Polish polish = new Polish();
            polish.DoService(robot, procedureTime);

            return $"{robotName} had polish procedure";
        }

        public string Rest(string robotName, int procedureTime)
        {
            DoesRobotExists(robotName);

            var robot = garage.Robots.Values.FirstOrDefault(r => r.Name == robotName);
            Rest rest = new Rest();
            rest.DoService(robot, procedureTime);

            return $"{robotName} had rest procedure";
        }

        public string Sell(string robotName, string ownerName)
        {
            DoesRobotExists(robotName);

            var robot = garage.Robots.Values.FirstOrDefault(r => r.Name == robotName);

            StringBuilder output = new StringBuilder();

            if (robot.IsChipped)
            {
                output.AppendLine($"{ownerName} bought robot with chip");
            }
            else
            {
                output.AppendLine($"{ownerName} bought robot without chip");
            }

            garage.Sell(robotName, ownerName);

            return output.ToString();

        }

        public string TechCheck(string robotName, int procedureTime)
        {
            DoesRobotExists(robotName);

            var robot = garage.Robots.Values.FirstOrDefault(r => r.Name == robotName);
            TechCheck techCheck = new TechCheck();
            techCheck.DoService(robot, procedureTime);

            return $"{robotName} had tech check procedure";
        }

        public string Work(string robotName, int procedureTime)
        {
            DoesRobotExists(robotName);

            var robot = garage.Robots.Values.FirstOrDefault(r => r.Name == robotName);
            Work work = new Work();
            work.DoService(robot, procedureTime);

            return $"{robotName} was working for {procedureTime} hours";
        }
    }
}
