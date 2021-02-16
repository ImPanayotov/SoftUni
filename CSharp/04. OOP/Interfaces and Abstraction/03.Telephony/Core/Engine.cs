using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Telephony
{
    public class Engine : IEngine
    {
        private StationaryPhone stationaryPhone;
        private Smartphone smartPhone;


        public Engine()
        {
            this.stationaryPhone = new StationaryPhone();
            this.smartPhone = new Smartphone();
        }

        public void Run()
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            string[] urls = Console.ReadLine().Split().ToArray();

            Calling(numbers);
            Browse(urls);
        }

        private static void Calling(string[] numbers)
        {
            Smartphone smartPhone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in numbers)
            {
                try
                {
                    if (number.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(number));
                    }
                    else if (number.Length == 10)
                    {
                        Console.WriteLine(smartPhone.Call(number));
                    }
                    else
                    {
                        throw new Exception("Invalid number!");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void Browse(string[] urls)
        {
            Smartphone smartPhone = new Smartphone();

            foreach (var url in urls)
            {
                try
                {
                    Console.WriteLine(smartPhone.Browse(url));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
