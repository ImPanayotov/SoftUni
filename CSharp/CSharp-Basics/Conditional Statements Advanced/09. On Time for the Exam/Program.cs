using System;

namespace _09._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double hourExam = double.Parse(Console.ReadLine());
            double minutesExam = double.Parse(Console.ReadLine());
            double hourArival = double.Parse(Console.ReadLine());
            double minutesArival = double.Parse(Console.ReadLine());

            double totalMinutesExam = (hourExam * 60) + minutesExam;
            double totalMinutesArival = (hourArival * 60) + minutesArival;
            string timing = "";
            double difference = 0;
            string message = "";

            if (totalMinutesExam == totalMinutesArival)
            {
                timing = "On time";
            }
            else if (totalMinutesExam > totalMinutesArival && totalMinutesArival >= totalMinutesExam - 30)
            {
                timing = "On time";
                difference = totalMinutesExam - totalMinutesArival;
                message = "before the start";
            }

            else if (totalMinutesArival < totalMinutesExam - 30)
            {
                timing = "Early";
                difference = totalMinutesExam - totalMinutesArival;
                message = "before the start";
            }
            else if (totalMinutesArival > totalMinutesExam)
            {
                timing = "Late";
                difference = totalMinutesArival - totalMinutesExam;
                message = "after the start";
            }

            double hour = Math.Floor(difference / 60);
            double minutes = difference % 60;
            if (minutes < 10)
            {
                if (hour >= 1)
                {
                    Console.WriteLine(timing);
                    Console.WriteLine($"{hour}:0{minutes} hours {message}");
                }
                else
                {
                    Console.WriteLine(timing);
                    Console.WriteLine($"{minutes} minutes {message}");
                }

            }
            else
            {
                if (hour >= 1)
                {
                    Console.WriteLine(timing);
                    Console.WriteLine($"{hour}:{minutes} hours {message}");
                }
                else
                {
                    Console.WriteLine(timing);
                    Console.WriteLine($"{minutes} minutes {message}");

                }
            }
        }
    }
}
