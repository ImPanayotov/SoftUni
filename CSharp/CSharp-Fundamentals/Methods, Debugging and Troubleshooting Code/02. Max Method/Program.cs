using System;

namespace _08._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            var type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());

                var result = GetMax(first, second);

                int third = int.Parse(Console.ReadLine());

                Console.WriteLine(result);
            }
            
        }


        static int GetMax(int first, int second)
        {
            var result = 0;
            if (first > second)
            {
                result = first;
            }
            else if (first < second)
            {
                result = second;
            }
            return result;
        }
        

        
    }
}
