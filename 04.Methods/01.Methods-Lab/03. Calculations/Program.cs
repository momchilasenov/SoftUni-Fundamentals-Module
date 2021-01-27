using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());

            if (input == "add")
            {
                AddTwoNumbers(numberOne, numberTwo);
            }
            else if (input == "subtract")
            {
                SubtractTwoNumbers(numberOne, numberTwo);
            }
            else if (input == "divide")
            {
                DivideTwoNumbers(numberOne, numberTwo);
            }
            else if (input == "multiply")
            {
                MultiplyTwoNumbers(numberOne, numberTwo);
            }
        }

        static double AddTwoNumbers(double numberOne, double numberTwo)
        {
            return numberOne + numberTwo;
        }
        static double SubtractTwoNumbers(double numberOne, double numberTwo)
        {
            return numberOne - numberTwo;
        }
        static double DivideTwoNumbers(double numberOne, double numberTwo)
        {
            return numberOne / numberTwo;
        }
        static double MultiplyTwoNumbers(double numberOne, double numberTwo)
        {
            return numberTwo * numberOne;
        }

    }
}
