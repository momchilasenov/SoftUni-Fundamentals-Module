using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace More_Exercises_01._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployees = int.Parse(Console.ReadLine());

            double maxAverageSalary = 0;
            string maxDepartment = string.Empty;
            List<Employee> employees = new List<Employee>();

            List<string> departments = new List<string>();

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string input = Console.ReadLine();
                string[] data = input.Split().ToArray();
                string name = data[0];
                double salary = double.Parse(data[1]);
                string department = data[2];

                if (!departments.Contains(department))
                {
                    departments.Add(department);
                }
                Employee newEmployee = new Employee(name, salary, department);
                employees.Add(newEmployee);
            }

            for (int i = 0; i < departments.Count; i++)
            {
                List<Employee> currentDepartment = employees
                    .FindAll(x => x.Department == departments[i]);
                double totalDepartmentSalary = currentDepartment.Sum(x => x.Salary);
                double averageSalary = totalDepartmentSalary / currentDepartment.Count;
                if (averageSalary > maxAverageSalary)
                {
                    maxDepartment = departments[i];
                    maxAverageSalary = averageSalary;
                }

            }

            List<Employee> maxEmployees = employees.FindAll(x => x.Department == maxDepartment);
            maxEmployees = maxEmployees.OrderByDescending(x => x.Salary).ToList();

            Console.WriteLine($"Highest Average Salary: {maxDepartment}");
            foreach (Employee employee in maxEmployees)
            {
                Console.Write(employee.Name);
                Console.Write($" {employee.Salary:f2}");
                Console.WriteLine();
            }


            //Console.WriteLine(string.Join(Environment.NewLine, employees
            //    .FindAll(x => x.Department == maxDepartment)
            //    .OrderByDescending(x=>x.Salary)));
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee(string name, double salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        //public override string ToString()
        //{
        //    StringBuilder maxEmployee = new StringBuilder();
        //    maxEmployee.AppendLine(this.Name);
        //    maxEmployee.Append(" ");
        //    maxEmployee.AppendLine(this.Salary);
            
        //    return maxEmployee.ToString(); 
        //}

    }
}
