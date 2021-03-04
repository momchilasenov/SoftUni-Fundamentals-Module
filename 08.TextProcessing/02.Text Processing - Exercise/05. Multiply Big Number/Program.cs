using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine().TrimStart('0');
            Console.WriteLine(first);
            int second = int.Parse(Console.ReadLine()); // 0 - 9
            
            StringBuilder sb = new StringBuilder();
            int extraDigit = 0;

            if (second == 0)
            {
                Console.WriteLine(0);
                return;
            }

            //while (first[0] == '0')
            //{
            //    first = first.Substring(1);
            //}

            for (int i = first.Length - 1; i >= 0; i--)
            {
                int currentDigit = first[i] - '0'; //3
                int currentDigit2 = int.Parse(first[i].ToString());
                int currentResult = currentDigit * second + extraDigit; //3*7 = 21
                extraDigit = 0;

                if (currentResult >= 10 && i > 0)
                {
                    extraDigit = currentResult / 10; //obtaining the first digit of the excess number
                    currentResult = currentResult % 10; //setting the second digit as a new result
                }

                sb.Insert(0, currentResult);
                


            }
            Console.WriteLine(sb);



        }
    }
}
