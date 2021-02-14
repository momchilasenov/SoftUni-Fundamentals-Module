using System;
using System.Collections.Generic;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<Student> students = new List<Student>();

            while (command != "end")
            {
                string[] commands = command.Split();

                Student newStudent = new Student
                {
                    FirstName = commands[0],
                    LastName = commands[1],
                    Age = int.Parse(commands[2]),
                    Hometown = commands[3]
                };

                students.Add(newStudent);

                command = Console.ReadLine();
            }

            string nameOfACity = Console.ReadLine();

            foreach(Student studentInfo in students)
            {
                if (studentInfo.Hometown == nameOfACity)
                {
                    Console.WriteLine($"{studentInfo.FirstName} {studentInfo.LastName} is {studentInfo.Age} years old.");
                }

            }

        }
    }

    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public string Hometown { get; set; }

    }
}
