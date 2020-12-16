using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Employees
    {
        public Dictionary<string, decimal> Names { get; set; }

        public decimal TotalSalary { get; set; }

        public int Counter { get; set; }

        public decimal AverageSalary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Employees> employees =
                new Dictionary<string, Employees>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine()
               .Split()
               .ToList();

                string name = input[0];
                decimal salary = decimal.Parse(input[1]);
                string department = input[2];

                if (!employees.ContainsKey(department))
                {
                    Employees employee = new Employees();
                    employee.Counter = 1;
                    employee.Names = new Dictionary<string, decimal>();
                    employee.Names.Add(name, salary);

                    employee.TotalSalary += salary;
                    employee.AverageSalary = employee.TotalSalary / employee.Counter;

                    employees[department] = employee;
                }
                else
                {
                    employees[department].Names.Add(name, salary);
                    employees[department].Counter++;
                    employees[department].TotalSalary += salary;
                    employees[department].AverageSalary = employees[department].TotalSalary / employees[department].Counter;
                }
            }

            //employees = employees
            //    .OrderByDescending(x => x.Value.AverageSalary)
            //    .ToDictionary(x => x.Key, y => y.Value);

            foreach (var department in employees
                .OrderByDescending(x => x.Value.AverageSalary)
                .ToDictionary(x => x.Key, y => y.Value)
                .Take(1))
            {
                Console.WriteLine($"Highest Average Salary: {department.Key}");

                foreach (var name in department.Value.Names
                    .OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"{name.Key} {name.Value:f2}");
                }
            }
        }
    }
}
