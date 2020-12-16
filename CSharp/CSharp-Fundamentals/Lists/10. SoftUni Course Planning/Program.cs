using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();
            int count = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "course start")
                {
                    for (int i = 0; i < schedule.Count; i++)
                    {
                        count++;
                        Console.WriteLine($"{count}.{schedule[i]}");
                    }
                    break;
                }
                string[] commands = input.Split(":").ToArray();

                if (commands[0] == "Add")
                {
                    Add(schedule, commands[1]);
                }
                else if (commands[0] == "Remove")
                {
                    Remove(schedule, commands[1]);
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[2]);
                    Insert(schedule, commands[1], index);
                }
                else if (commands[0] == "Swap")
                {
                    Swap(schedule, commands[1], commands[2]);
                }
                else if (commands[0] == "Exercise")
                {
                    Exercise(schedule, commands[1]);
                }
            }

        }

        public static List<string> Add(List<string> schedule, string lessonTitle)
        {
            if (!schedule.Contains(lessonTitle))
            {
                schedule.Add(lessonTitle);
            }
            return schedule;
        }
        public static List<string> Remove(List<string> schedule, string lessonTitle)
        {
            string lessonExercise = string.Concat(lessonTitle, "-Exercise");

            if (schedule.Contains(lessonTitle) || schedule.Contains(lessonExercise))
            {
                schedule.Remove(lessonTitle);
                schedule.Remove(lessonExercise);
            }
            return schedule;
        }
        public static List<string> Insert(List<string> schedule, string lessonTitle, int index)
        {
            if (!schedule.Contains(lessonTitle))
            {
                if (index >= 0 && index < schedule.Count)
                {
                schedule.Insert(index, lessonTitle);
                }
            }
            return schedule;
        }
        public static List<string> Swap(List<string> schedule, string lessonTitle1, string lessonTitle2)
        {
            if (schedule.Contains(lessonTitle1) && schedule.Contains(lessonTitle2))
            {
                int indexLessonTitle1 = schedule.IndexOf(lessonTitle1);
                int indexLessonTitle2 = schedule.IndexOf(lessonTitle2);

                string temp = schedule[indexLessonTitle1];
                schedule[indexLessonTitle1] = schedule[indexLessonTitle2]; ;
                schedule[indexLessonTitle2] = temp;

                string lessonExercise1 = string.Concat(lessonTitle1, "-Exercise");
                string lessonExercise2 = string.Concat(lessonTitle2, "-Exercise");

                if (schedule.Contains(lessonExercise1))
                {
                    int indexExerciseTitle1 = schedule.IndexOf(lessonExercise1);
                    schedule.Insert(schedule.IndexOf(lessonTitle1) + 1, lessonExercise1);
                    schedule.RemoveAt(indexExerciseTitle1 + 1);
                    
                }
                if (schedule.Contains(lessonExercise2))
                {
                    int indexExerciseTitle2 = schedule.IndexOf(lessonExercise2);
                    schedule.Insert(schedule.IndexOf(lessonTitle2) + 1, lessonExercise2);
                    schedule.RemoveAt(indexExerciseTitle2 + 1);
                }
            }
            return schedule;
        }
        public static List<string> Exercise(List<string> schedule, string lessonTitle)
        {
            if (schedule.Contains(lessonTitle) && !schedule.Contains(string.Concat(lessonTitle, "-Exercise")))
            {
                int index = schedule.IndexOf(lessonTitle);
                schedule.Insert(index + 1, string.Concat(schedule[index], "-Exercise"));
            }
            else if (!schedule.Contains(string.Concat(lessonTitle, "-Exercise")))
            {
                string lessonExercise = string.Concat(lessonTitle, "-Exercise");
                schedule.Add(lessonTitle);
                schedule.Add(lessonExercise);
            }
            return schedule;
        }
    }
}
