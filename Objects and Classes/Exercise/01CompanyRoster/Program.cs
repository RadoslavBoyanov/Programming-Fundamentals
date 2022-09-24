using System;
using System.Collections.Generic;
using System.Linq;

namespace _01CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] line = Console.ReadLine().Split(' ').ToArray();
                string name = line[0];
                decimal salary = decimal.Parse(line[1]);
                string department = line[2];

                Employee employee = new Employee();
                employee.Name = name;
                employee.Salary = salary;
                employee.Department = department;

                employees.Add(employee);

            }

            GetSplit(employees);
        }

        private static void GetSplit(List<Employee> employees)
        {
            decimal salary = 0;
            decimal maxSalary = Decimal.MinValue;
            foreach (var employee in employees)
            {
                if (employee.Department == employee.Department)
                {
                     
                }
            }
        }

        class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Department { get; set; }
        }
    }
}
