using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Exceptions;
using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = this.TryParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        private Corps TryParseCorps(string corpsStr)
        {
            bool parsed = Enum.TryParse<Corps>(corpsStr, out Corps corps);

            if (!parsed)
            {
                throw new InvalidCorpsException();
            }

            return corps;
        }
    }
}
