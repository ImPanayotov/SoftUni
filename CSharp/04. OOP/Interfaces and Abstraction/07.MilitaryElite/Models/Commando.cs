﻿using _07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07.MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private ICollection<IMission> missions;
        public Commando(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => (IReadOnlyCollection<IMission>)this.missions;

        public void AddMission(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {this.Corps.ToString()}");
            sb.AppendLine("Missions:");
            foreach (var item in this.Missions)
            {
                sb.AppendLine($"  {item.ToString()}");
            }
            return sb.ToString().Trim();
        }
    }
}
