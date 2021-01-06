using System;

namespace _09._Padawan_Equipment_
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyAvailable = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double numberOfSabers = Math.Ceiling(numberOfStudents + numberOfStudents * 0.10);
            double freeBelts = numberOfStudents / 6;

            double total = (numberOfSabers * saberPrice) + (numberOfStudents * robePrice) + (numberOfStudents * beltPrice) - (freeBelts * beltPrice);

            if (moneyAvailable >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total-moneyAvailable:f2}lv more.");
            }


        }
    }
}
