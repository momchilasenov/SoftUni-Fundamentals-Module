using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            bool isSpecial = false;

            for (int i = 1; i <= numbers; i++)
            {
                int sumOfDigits = 0;
                int digit = i; 
                while (digit > 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }

                isSpecial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecial);
            }

        }
    }
}
