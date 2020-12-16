using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string username;
        private int health;
        private int armor;
        private IGun gun;

        protected Player(string username, int health, int armor, IGun gun)
        {
            Username = username;
            Health = health;
            Armor = armor;
            Gun = gun;
        }

        public string Username
        {
            get
            {
                return username;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Username cannot be null or empty.");
                }

                username = value;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
            private set
            {
                if (value <= 0) // If there's an error - check the value for EQUAL or BELOW ZERO
                {
                    throw new ArgumentException("Player health cannot be below or equal to 0.");
                }

                health = value;
            }
        }

        public int Armor
        {
            get
            {
                return armor;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player armor cannot be below 0.");
                }

                armor = value;
            }
        }

        public IGun Gun
        {
            get
            {
                return gun;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("Gun cannot be null or empty.");
                }

                gun = value;
            }
        }

        public bool IsAlive
        {
            get
            {
                return health > 0;
            }
        }

        public void TakeDamage(int points)
        {
            if (armor - points >= 0)
            {
                armor -= points;
                return;
            }
            else if (armor > 0)
            {
                points -= armor;
                armor = 0;
            }

            health -= points;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"{GetType().Name}: {Username}");
            result.AppendLine($"--Health: {Health}");
            result.AppendLine($"--Armor: {Armor}");
            result.AppendLine($"--Gun: {Gun.Name}");

            return result.ToString().Trim();
        }
    }
}
