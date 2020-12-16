using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotService.Models.Procedures
{
    public class Chip : Procedure
    {
        public Chip()
        {
        }

        //– removes 5 happiness and chips current robot.Robot can be chipped once.If robot is already chipped throw an ArgumentException with message "{robot name} is already chipped"

        public override void DoService(IRobot robot, int procedureTime)
        {
            if (procedureTime > robot.ProcedureTime)
            {
                throw new ArgumentException("Robot doesn't have enough procedure time");
            }

            robot.Happiness -= 5;

            if (robot.IsChipped)
            {
                throw new ArgumentException($"{robot.Name} is already chipped");
            }

            robot.IsChipped = true;

            robot.ProcedureTime -= procedureTime;
            Robots.Add(robot);
        }

        
    }
}
