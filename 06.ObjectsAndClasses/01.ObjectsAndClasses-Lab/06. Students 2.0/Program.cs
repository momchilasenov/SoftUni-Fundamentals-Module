using System;
using System.Collections.Generic;

namespace _06._Students_2._0
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

                string firstName = commands[0];
                string lastName = commands[1];
                int age = int.Parse(commands[2]);
                string hometown = commands[3];

                if (DoesStudentExist(students,firstName,lastName)) //if the student already exists
                {
                    Student student = GetStudents(students, firstName, lastName);

                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.Hometown = hometown;

                }
                else
                {
                    Student newStudent = new Student
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        Hometown = hometown
                    };

                    students.Add(newStudent);
                }
                

                command = Console.ReadLine();
            }

            string nameOfACity = Console.ReadLine();

            foreach (Student studentInfo in students)
            {
                if (studentInfo.Hometown == nameOfACity)
                {
                    Console.WriteLine($"{studentInfo.FirstName} {studentInfo.LastName} is {studentInfo.Age} years old.");
                }
            }
        }
        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }

        static Student GetStudents (List<Student> students, string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;

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

