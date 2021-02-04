using System;

namespace More_Exercises_03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ax1 = double.Parse(Console.ReadLine());
            double Ay1 = double.Parse(Console.ReadLine());
            double Ax2 = double.Parse(Console.ReadLine());
            double Ay2 = double.Parse(Console.ReadLine());
            string pointsInA = GetCloserPoint(Ax1, Ay1, Ax2, Ay2);
            double lengthOfLineA = GetLineLength(Ax1, Ay1, Ax2, Ay2);

            double Bx1 = double.Parse(Console.ReadLine());
            double By1 = double.Parse(Console.ReadLine());
            double Bx2 = double.Parse(Console.ReadLine());
            double By2 = double.Parse(Console.ReadLine());
            string pointsInB = GetCloserPoint(Bx1, By1, Bx2, By2);
            double lengthOfLineB = GetLineLength(Bx1, By1, Bx2, By2);

            if (lengthOfLineA > lengthOfLineB)
            {
                Console.WriteLine(pointsInA);
            }
            else
            {
                Console.WriteLine(pointsInB);
            }
        }

        static double GetLineLength (double x1, double y1, double x2, double y2)
        {
            double sum1 = Math.Abs(x1) + Math.Abs(y1);
            double sum2 = Math.Abs(x2) + Math.Abs(y2);
            double lineLength = sum1 + sum2;
            return lineLength;
        }

        static string GetCloserPoint(double x1, double y1, double x2, double y2)
        {
            double sum1 = Math.Abs(x1) + Math.Abs(y1);
            double sum2 = Math.Abs(x2) + Math.Abs(y2);

            if (sum1 > sum2)
            {
                return $"({x2}, {y2})({x1}, {y1})";
            }
            else if (sum2 > sum1)
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }
            else //equal points
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }
        }
    }
}
