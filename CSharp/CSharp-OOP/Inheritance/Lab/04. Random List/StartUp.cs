using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();
            list.Add("ivo");
            list.Add("ivo2");
            list.Add("ivo3");
            list.Add("ivo4");

            Console.WriteLine(list.RandomString());
        }
    }
}
