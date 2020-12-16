using System;

namespace Cars
{
    internal class Seat : ICar
    {
        private string model;
        private string color;

        public Seat(string model, string color)
        {
            this.model = model;
            this.color = color;
        }


        public string Model { get; set; }

        public string Color { get; set; }


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
            return $"{color} {nameof(Seat)} {model}";
        }
    }
}