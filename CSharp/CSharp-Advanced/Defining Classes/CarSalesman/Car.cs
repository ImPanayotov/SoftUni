using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
		private string model;
		private Engine engine;
		private string weight = "n/a";
		private string color = "n/a";

		public string Model { get => model; set => model = value; }
		public Engine Engine { get => engine; set => engine = value; }
		public string Weight { get => weight; set => weight = value; }
		public string Color { get => color; set => color = value; }
	}
}
