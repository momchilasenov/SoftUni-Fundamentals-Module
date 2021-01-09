using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            for (int i=1; i<=number; i++)
            {
                int digitsSum = 0;
                int digits = i; 

                while (digits != 0) //докато има цифри въртим цикъла
                {
                    digitsSum += digits % 10; //от 485 вземаме 5
                    digits = digits / 10; // 485/10 = остава 48
                }

                bool isSpecial = (digitsSum == 5) || (digitsSum == 7) || (digitsSum == 11);

                if (isSpecial)
                {
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
                else
                {
                    Console.WriteLine($"{i} -> {isSpecial}");
                }
            }
        }
    }
}
