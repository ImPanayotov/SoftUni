using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roaster;
        

        public Guild(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            roaster = new List<Player>();
        }


        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count { get { return roaster.Count; } }


        public void AddPlayer(Player player)
        {
            if (roaster.Count < Capacity)
            {
                roaster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            Player playerToRemove = roaster.FirstOrDefault(p => p.Name == name);

            if (playerToRemove != null)
            {
                roaster.Remove(playerToRemove);

                return true;
            }

            return false;
        }

        public void PromotePlayer(string name)
        {
            Player playerToPromote = roaster.FirstOrDefault(p => p.Name == name);

            if (playerToPromote != null && playerToPromote.Rank == "Trial")
            {
                playerToPromote.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            Player playerToDemotee = roaster.FirstOrDefault(p => p.Name == name);

            if (playerToDemotee != null && playerToDemotee.Rank == "Member")
            {
                playerToDemotee.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string @class)
        {
            
            Player[] kickedPlayersAsArray = roaster.Where(p => p.Class == @class).ToArray();
            roaster = roaster.Where(p => p.Class != @class).ToList();
            
            return kickedPlayersAsArray.ToArray();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Players in the guild: {Name}");

            foreach (var player in roaster)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
