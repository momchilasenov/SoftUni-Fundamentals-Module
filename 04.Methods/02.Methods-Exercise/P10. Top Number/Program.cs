using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CheckTopNumbers(number);
        }

        static void CheckTopNumbers(int number)
        {
            for (int i = 14; i <= number; i++)
            {
                int result = CheckOddNumber(i);
                if (result != 0)
                {
                    Console.WriteLine(result);
                }
            }
        }

        static int CheckOddNumber(int number)
        {
            int divisibleByEight = CheckNumberSum(number);

            if (divisibleByEight != 0)
            {
                string stringNumber = divisibleByEight.ToString();
                for (int i = 0; i < stringNumber.Length; i++)
                {
                    if (stringNumber[i] % 2 != 0)
                    {
                        return divisibleByEight;
                    }
                }
            }
            return 0;

        }

        static int CheckNumberSum(int number)
        {
            string stringNumber = number.ToString();
            
            int sum = 0;

            for (int j = 0; j < stringNumber.Length; j++)
            {
                
                sum += int.Parse(stringNumber[j].ToString());
            }
            if (sum % 8 == 0)
            {
                return number;
            }
            else
            {
                return 0;
            }

        }
    }
}
