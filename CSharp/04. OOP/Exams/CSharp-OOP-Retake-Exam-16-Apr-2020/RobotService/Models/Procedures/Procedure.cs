using RobotService.Models.Procedures.Contracts;
using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {

        public Procedure()
        {
            Robots = new List<IRobot>();
        }


        protected IList<IRobot> Robots { get; }

        public virtual void DoService(IRobot robot, int procedureTime)
        {
            if (procedureTime > robot.ProcedureTime)
            {
                throw new ArgumentException("Robot doesn't have enough procedure time");
            }
        }
        



        public string History()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{GetType().Name}"); // Eventually will be get type . name
            foreach (var robot in Robots)
            {
                result.AppendLine(robot.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}
