using System;
using System.Text;

namespace Cars
{
    internal class Tesla : ICar, IElectricCar
    {
        private string model;
        private string color;
        private int battery;

        public Tesla(string model, string color, int battery)
        {
            this.model = model;
            this.color = color;
            this.battery = battery;
        }


        public string Model { get; set; }

        public string Color { get; set; }

        public int Battery { get; set; }


        public void Start()
        {
            Console.WriteLine("Engine start");
        }

        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }


        public override string ToString()
        {
            return $"{color} {nameof(Tesla)} {model} with {battery} Batteries";
        }
    }
}