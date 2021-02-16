using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());
            float hourTime = hours + minutes / 60 + seconds / 3600.0f;
            float kmSpeed = (distance / 1000.0f) / hourTime;
            float metersSpeed = kmSpeed / 3.6f;
            float milesSpeed = (distance / 1609.0f) / hourTime;

            Console.WriteLine("{0}", metersSpeed);
            Console.WriteLine("{0}", kmSpeed);
            Console.WriteLine("{0}", milesSpeed);
        }
    }
}
