using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> studentData = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                int gradeCounter = 1;
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentData.ContainsKey(name) == false)
                {
                    studentData.Add(name, grade);
                }
                else
                {
                    gradeCounter++;
                    studentData[name] += grade;
                    studentData[name] /= gradeCounter;
                }
            }
            foreach (var student in studentData
                .Where(x=>x.Value >= 4.50)
                .OrderByDescending(n => n.Value))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
