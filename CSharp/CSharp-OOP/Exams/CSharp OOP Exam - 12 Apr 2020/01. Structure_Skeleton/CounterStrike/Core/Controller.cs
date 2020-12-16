using CounterStrike.Core.Contracts;
using CounterStrike.Models.Guns;
using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Maps;
using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Core
{
    public class Controller : IController
    {
        private GunRepository guns;
        private PlayerRepository players;
        private IMap map;

        public Controller()
        {
            guns = new GunRepository();
            players = new PlayerRepository();
            map = new Map();
        }

        public string AddGun(string type, string name, int bulletsCount)
        {
            IGun gun;

            if (type == "Pistol")
            {
                gun = new Pistol(name, bulletsCount);
            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name, bulletsCount);
            }
            else
            {
                throw new ArgumentException("Invalid gun type!");
            }

            guns.Add(gun);

            return $"Successfully added gun {name}.";
        }

        public string AddPlayer(string type, string username, int health, int armor, string gunName)
        {
            IPlayer player;
            IGun gun = guns.FindByName(gunName);

            if (gun == null)
            {
                throw new ArgumentException("Gun cannot be found!");
            }

            if (type == "Terrorist")
            {
                player = new Terrorist(username, health, armor, gun);
            }
            else if (type == "CounterTerrorist")
            {
                player = new CounterTerrorist(username, health, armor, gun);

            }
            else
            {
                throw new ArgumentException("Invalid player type!");
            }

            players.Add(player);

            return $"Successfully added player {username}.";
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();

            var sortedPlayers = players.Models
                                .OrderBy(p => p.GetType().Name)
                                .ThenByDescending(p => p.Health)
                                .ThenBy(p => p.Username);

            foreach (var player in sortedPlayers)
            {
                result.AppendLine(player.ToString());

            }

            return result.ToString().TrimEnd();
        }

        public string StartGame()
        {
            return map.Start(players.Models.ToList());
        }
    }
}
