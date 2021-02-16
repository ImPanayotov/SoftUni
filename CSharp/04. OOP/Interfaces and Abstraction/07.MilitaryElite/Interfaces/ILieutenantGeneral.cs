using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        public IReadOnlyCollection<ISpecialisedSoldier> Privates { get; }

        public void AddPrivate(ISoldier @private);
    }
}
