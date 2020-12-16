using System;
using System.Linq;

namespace Tasks_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tasks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = input[0];

                if (command == "End")
                {
                    break;
                }

                if (command == "Complete")
                {
                    int index = int.Parse(input[1]);
                    Complete(tasks, index);
                }
                else if (command == "Change")
                {
                    int index = int.Parse(input[1]);
                    int time = int.Parse(input[2]);
                    Change(tasks, index, time);
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(input[1]);
                    Drop(tasks, index);
                }
                else if (command == "Count")
                {
                    string secondCommand = input[1];

                    if (secondCommand == "Completed")
                    {
                        CountCompleted(tasks);
                    }
                    else if (secondCommand == "Incomplete")
                    {
                        CountIncomplete(tasks);
                    }
                    else if (secondCommand == "Dropped")
                    {
                        CountDropped(tasks);
                    }
                }
            }

            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i] > 0)
                {
                    Console.Write(tasks[i] + " ");
                }
            }
        }

       public static int[] Complete(int[] tasks, int index)
        {
            if (index >= 0 && index < tasks.Length)
            {
                tasks[index] = 0;
            }

            return tasks;
        }

        public static int[] Change(int[] tasks, int index, int time)
        {
            if (index >= 0 && index < tasks.Length)
            {
                tasks[index] = time;
            }

            return tasks;
        }

        public static int[] Drop(int[] tasks, int index)
        {
            if (index >= 0 && index < tasks.Length)
            {
                tasks[index] = -1;
            }

            return tasks;
        }

        public static void CountCompleted(int[] tasks)
        {
            int count = 0;

            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i] == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public static void CountIncomplete(int[] tasks)
        {
            int count = 0;

            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i] > 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public static void CountDropped(int[] tasks)
        {
            int count = 0;

            for (int i = 0; i < tasks.Length; i++)
            {
                if (tasks[i] == -1)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
