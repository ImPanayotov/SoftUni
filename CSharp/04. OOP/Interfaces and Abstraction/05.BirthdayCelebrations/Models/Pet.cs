using _05.BirthdayCelebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05.BirthdayCelebrations.Models
{
    public class Pet : IBirthday
    {
        public Pet(string name, string birthday)
        {
            Name = name;
            Birthday = birthday;
        }

        public string Name { get; set; }
        public string Birthday { get; private set; }

    }
}
