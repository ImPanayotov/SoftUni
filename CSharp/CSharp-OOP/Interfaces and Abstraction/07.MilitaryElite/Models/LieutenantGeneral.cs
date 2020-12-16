using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<ISoldier> privates;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }


        IReadOnlyCollection<ISpecialisedSoldier> ILieutenantGeneral.Privates => (IReadOnlyCollection<ISpecialisedSoldier>)(IReadOnlyCollection<ISoldier>) this.privates;

        public void AddPrivate(ISoldier @private)
        {
            this.privates.Add(@private);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var item in this.privates)
            {
                sb.AppendLine($"  {item.ToString()}");
            }

            return sb.ToString().Trim();
        }

    }
}
