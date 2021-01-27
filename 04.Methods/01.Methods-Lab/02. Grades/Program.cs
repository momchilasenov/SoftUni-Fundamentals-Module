using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grades(grade);
        }

        static void Grades(double grade)
        {
            string score = " ";
            if (grade>=2.00 && grade <= 2.99)
            {
                score = "Fail";
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                score = "Poor";
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                score = "Good";
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                score = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                score = "Excellent";
            }
            Console.WriteLine(score);
        }
    }
}
