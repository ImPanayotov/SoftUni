using RobotService.Models.Robots.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RobotService.Models.Procedures
{
    public class TechCheck : Procedure
    {
        public TechCheck()
        {
        }

        public override void DoService(IRobot robot, int procedureTime)
        {
            if (procedureTime > robot.ProcedureTime)
            {
                throw new ArgumentException("Robot doesn't have enough procedure time");
            }
            if (robot.IsChecked)
            {
                robot.Energy -= 16;
                return;
            }

            robot.Energy -= 8;
            robot.IsChecked = true;

            robot.ProcedureTime -= procedureTime;
            Robots.Add(robot);
        }
    }
}
