using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Robots
{
    public abstract class Robot : IRobot
    {
        private int happiness;
        private int energy;

        public Robot(string name, int energy, int happiness, int procedureTime)
        {
            Name = name;
            Energy = energy;
            Happiness = happiness;
            ProcedureTime = procedureTime;
        }
        public string Name { get; private set; }
        public int Happiness
        {
            get
            {
                return happiness;
            }
             set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid happiness");
                }

                happiness = value;
            }
        }
        public int Energy
        {
            get
            {
                return energy;
            }
             set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException("Invalid energy");
                }

                energy = value;
            }
        }
        public int ProcedureTime { get;  set; }
        public virtual string Owner { get; set; } = "Service";      //CHECK IF ERROR
        public bool IsBought { get;  set; }
        public bool IsChipped { get;  set; }
        public bool IsChecked { get;  set; }


        public override string ToString()
        {
            return $" Robot2 type: {GetType().Name} - {Name} - Happiness: {Happiness} - Energy: {Energy}";
        }
    }
}
