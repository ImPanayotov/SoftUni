using CounterStrike.Models.Guns.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Guns
{
    public abstract class Gun : IGun
    {
        private string name;
        private int bulletsCount;

        public Gun(string name, int bulletsCount)
        {
            Name = name;
            BulletsCount = bulletsCount;
        }

        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gun cannot be null or empty.");
                }

                name = value;
            }
        }

        public int BulletsCount
        {
            get
            {
                return bulletsCount;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Bullets cannot be below 0.");
                }

                bulletsCount = value;
            }
        }

        abstract protected int FireRate { get; }

        public int Fire()
        {
            if (BulletsCount - FireRate >= 0)
            {
                BulletsCount -= FireRate;
                return FireRate;
            }
            else
            {
                int bulletsLeft = BulletsCount;
                BulletsCount = 0;

                return bulletsLeft;
            }
        }

    }
}
