using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        private List<IPlayer> terrorists;
        private List<IPlayer> counterTerrorists;

        public Map()
        {
            terrorists = new List<IPlayer>();
            counterTerrorists = new List<IPlayer>();
        }

        public string Start(ICollection<IPlayer> players)
        {
            SeparateTeams(players);
            string winMessage = string.Empty;

            while (isTeamAlive(terrorists) && isTeamAlive(counterTerrorists))
            {
                AttackTeam(terrorists, counterTerrorists);
                AttackTeam(counterTerrorists, terrorists);

                if (isTeamAlive(counterTerrorists))
                {
                    winMessage = "Counter Terrorist wins!";
                }
                else if (isTeamAlive(terrorists))
                {
                    winMessage = "Terrorist wins!";
                }
            }

            return winMessage;
        }

        private bool isTeamAlive(List<IPlayer> players)
        {
            return players.Any(p => p.IsAlive);
        }

        private void AttackTeam(List<IPlayer> attackingTeam, List<IPlayer> defendingTeam)
        {
            foreach (var attacker in attackingTeam)
            {
                if (!attacker.IsAlive)
                {
                    continue;
                }

                foreach (var defender in defendingTeam)
                {
                    if (defender.IsAlive)
                    {
                        defender.TakeDamage(attacker.Gun.Fire());
                    }
                }
            }
        }

        private void SeparateTeams(ICollection<IPlayer> players)
        {
            foreach (var player in players)
            {
                if (player is CounterTerrorist)
                {
                    counterTerrorists.Add(player);
                }
                else if (player is Terrorist)
                {
                    terrorists.Add(player);
                }
            }
        }
    }
}
