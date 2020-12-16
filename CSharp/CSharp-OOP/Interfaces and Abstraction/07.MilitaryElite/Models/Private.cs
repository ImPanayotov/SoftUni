using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    public class Private : Soldier
    {
        public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            Salary = salary;
        }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($" Salary: {this.Salary:F2}");

            return sb.ToString().Trim();
        }
    }
}
