using System;
using System.Collections.Generic;
using System.Text;

namespace Guild
{
    public class Player
    {
        private static string rank;
        private static string description;

        public Player(string name, string @class)
        {
            Name = name;
            Class = @class;
            Rank = "Trial";
            Description = "n/a";

        }

        public Player(string name, string @class, string rank, string description)
        {
            Name = name;
            Class = @class;
            Rank = "Trial";
            Description = "n/a";
        }


        public string Name { get; set; }

        public string Class { get; set; }

        public string Rank { get; set; }

        public string Description { get; set; }


        public override string ToString()
        {         
            return $"Player {Name}: {Class}{Environment.NewLine}Rank: {Rank}{Environment.NewLine}Description: {Description}";
        }
    }
}
