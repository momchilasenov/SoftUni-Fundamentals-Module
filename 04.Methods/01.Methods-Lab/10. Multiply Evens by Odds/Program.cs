using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            ;
            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);

        }

        static int GetSumOfEvenDigits(int number) //12345
        {
            int evenSum = 0;
            string n = number.ToString();
            for (int i = 0; i < n.Length; i++) //length=5
            {
                if (n[i] % 2 == 0)
                {
                    evenSum += int.Parse(n[i].ToString());
                }
            }
            return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            string n = number.ToString();

            for (int i=0; i<n.Length; i++)
            {
                if (n[i] % 2 != 0)
                {
                    oddSum += int.Parse(n[i].ToString());
                }
            }
            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetSumOfEvenDigits(number) * GetSumOfOddDigits(number);
              
        }
    }
}
