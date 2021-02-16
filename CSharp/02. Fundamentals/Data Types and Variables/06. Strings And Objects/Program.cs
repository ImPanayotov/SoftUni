using System;

namespace _06._Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = ("Hello" + " " + "World");
            string sentence = (string)helloWorld;
            Console.WriteLine(sentence);
        }
    }
}
