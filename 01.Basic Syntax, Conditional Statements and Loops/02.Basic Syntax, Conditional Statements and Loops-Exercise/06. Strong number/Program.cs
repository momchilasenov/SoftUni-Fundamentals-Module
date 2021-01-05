using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // algorithm
            // 145 % 10 = 5
            // 145 - 5 = 140 / 10 = 14
            // 14 % 10 = 4
            // 14 - 4 = 10 / 10 = 1
            // 1 % 10 = 1

            int num = int.Parse(Console.ReadLine());
            int tempNum = num;
            string strNum = "";
            strNum += num; // "145"
            int sum = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentDigit = tempNum % 10;
                tempNum = (tempNum - currentDigit) / 10;

                int factorial = 1; //искаш за всяка цифра факториелът да е нов  

                for (int j = 1; j<=currentDigit; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            if (sum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
