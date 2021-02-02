using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PalindromeChecker(input);
        }

        static void PalindromeChecker(string input)
        {

            while (input != "END")
            {
                string reversedString = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--) //3223
                {
                    reversedString += input[i];
                }
                if (reversedString == input)
                {

                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }
    }
}
