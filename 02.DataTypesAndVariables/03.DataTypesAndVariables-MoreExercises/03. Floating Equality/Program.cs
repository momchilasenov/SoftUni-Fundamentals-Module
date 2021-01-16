using System;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            if ((numberOne - numberTwo < eps) && (numberTwo - numberOne < eps))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
