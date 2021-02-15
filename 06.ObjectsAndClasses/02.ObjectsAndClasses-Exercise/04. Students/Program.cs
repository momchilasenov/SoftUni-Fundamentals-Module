using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 1; i <= n; i++)
            {
                string[] newStudent = Console.ReadLine()
                    .Split()
                    .ToArray();

                string firstName = newStudent[0];
                string lastName = newStudent[1];
                double grade = double.Parse(newStudent[2]);

                Student currentStudent = new Student(firstName, lastName, grade);

                students.Add(currentStudent);

            }

            //first way
            students = students.OrderByDescending(x => x.Grade).ToList();
            Console.WriteLine(String.Join(Environment.NewLine, students));

            //second way
            Console.WriteLine(String.Join(Environment.NewLine, students.OrderByDescending(x => x.Grade).ToList()));
        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
