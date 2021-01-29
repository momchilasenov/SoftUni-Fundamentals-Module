using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            //double number = double.Parse(Console.ReadLine());
            //double power = double.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(NumberToGivenPower(number,power));
        }
       
        static int NumberToGivenPower(int number, int power)
        {
            int result = 1;
            for (int i=0; i<power; i++)
            {
                result *= number;
            }
            return result;
        } 
    }
}
