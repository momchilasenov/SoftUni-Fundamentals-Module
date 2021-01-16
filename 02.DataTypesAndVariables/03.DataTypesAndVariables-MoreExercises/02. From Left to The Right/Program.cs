using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 0; i < number; i++)
            {
                string numbers = Console.ReadLine(); 
                string[] numbersArray = numbers.Split(" ");
                int sum1 = 0;
                int sum2 = 0;

                long number1 = long.Parse(numbersArray[0]);
                long number2 = long.Parse(numbersArray[1]);

                if (number1 > number2) 
                {
                    int length1 = number1.ToString().Length; 
                    for (int j = 0; j < length1; j++)
                    {
                        long digit1 = number1 % 10;
                        number1 /= 10;
                        sum1 += (int)digit1;
                    }
                    Console.WriteLine(sum1);
                }
                else
                {
                    int length2 = number2.ToString().Length;
                    for (int k = 0; k < length2; k++)
                    {
                        long digit2 = number2 % 10;
                        number2 /= 10;
                        sum2 += (int)digit2;
                    }
                    Console.WriteLine(sum2);
                }
            }
        }
    }
}
