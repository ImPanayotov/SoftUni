using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public class Polish : Procedure
    {
        public Polish()
        {
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            if (procedureTime > robot.ProcedureTime)
            {
                throw new ArgumentException("Robot doesn't have enough procedure time");
            }
            robot.Happiness +=12;
            robot.Energy -= 6;

            robot.ProcedureTime -= procedureTime;
            Robots.Add(robot);
        }
    }
}
