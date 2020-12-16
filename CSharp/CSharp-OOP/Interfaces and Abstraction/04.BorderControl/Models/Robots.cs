using _05.BirthdayCelebrations.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Robots : IId
    {
        public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }
        public string Id { get; }
        public string Birthday { get; }
    }
}
