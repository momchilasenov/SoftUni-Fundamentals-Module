using System;
using System.Linq;
using System.Collections.Generic;


namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] data = input.Split(':');
                string course = data[0].Trim();
                string name = data[1].Trim();

                if (courses.ContainsKey(course))
                {
                    courses[course].Add(name);
                }
                else
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(name);

                }
                input = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
