using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _05._Students
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Hometown { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }
                List<string> inputInfo = input.Split().ToList();

                string firstName = inputInfo[0];
                string lastName = inputInfo[1];
                int age = int.Parse(inputInfo[2]);
                string homeTown = inputInfo[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    Hometown = homeTown
                };

                students.Add(student);
            }
            string filter = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.Hometown == filter)
                {
                    Console.WriteLine($"{student.FirstName}" +
                        $" {student.LastName}" +
                        $" is {student.Age} years old.");
                }
            }
        }
    }
}