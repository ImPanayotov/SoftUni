using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniContext();
            // Console.WriteLine(GetEmployeesFullInformation(context)); // 03.
            // Console.WriteLine(GetEmployeesWithSalaryOver50000(context)); // 04.
            // Console.WriteLine(GetEmployeesFromResearchAndDevelopment(context)); // 05.
            // Console.WriteLine(AddNewAddressToEmployee(context)); // 06.
            

        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    ManagerFirstName = e.Manager.FirstName,
                    ManagerLastName = e.Manager.LastName,
                    Projects = e.EmployeesProjects
                    .Select(ep => new
                    {
                        ProjectName = ep.Project.Name,
                        StartDate = ep.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                        EndDate = ep.Project.EndDate.HasValue ?
                                ep.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                                : "not finished"
                    }).ToList()
                })
                .ToList();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} from {e.Department.Name} - ${e.Salary:f2}");
            }

            return result.ToString();
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();
            Address newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(newAddress);// EFC will added even without that command
            Employee employee = context.Employees
                .First(e => e.LastName == "Nakov");
            employee.Address = newAddress;

            context.SaveChanges();

            List<string> employeesAdresses = context.Employees
                .OrderByDescending(e => e.AddressId)
                 .Take(10)
                .Select(e => e.Address.AddressText)
                 .ToList();

            foreach (string address in employeesAdresses)
            {
                sb.AppendLine(address);
            }

            return sb.ToString().Trim();
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .OrderBy(x => x.Salary)
                .ThenByDescending(x => x.FirstName)
                .Select(e => new Employee
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Department = e.Department,
                    Salary = e.Salary
                })
                .Where(e => e.Department.Name == "Research and Development")
                .ToList();

            foreach (var e in employees)
            {
                result.AppendLine($"{e.FirstName} {e.LastName} from {e.Department.Name} - ${e.Salary:f2}");
            }

            return result.ToString();
        }
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder result = new StringBuilder();

            var employees = context.Employees
                .OrderBy(x => x.FirstName)
                .Select(e => new Employee
                {
                    FirstName = e.FirstName,
                    Salary = e.Salary
                })
                .Where(e => e.Salary > 50000)
                .ToList();

            foreach (var employee in employees)
            {
                result.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }

            return result.ToString();
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e =>new Employee
                {
                    FirstName=e.FirstName,
                    LastName=e.LastName,
                    MiddleName=e.MiddleName,
                    JobTitle=e.JobTitle,
                    Salary=e.Salary
                })
                .ToList();

            foreach (var item in employees)
            {
                sb.AppendLine(item.FirstName + " " + item.LastName + " " + item.MiddleName + " " + item.JobTitle + " " + $"{item.Salary:f2}");
            }

            return sb.ToString();
        }         
    }
}
