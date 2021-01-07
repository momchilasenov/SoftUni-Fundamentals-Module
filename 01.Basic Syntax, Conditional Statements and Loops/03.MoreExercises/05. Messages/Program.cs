using System;

namespace More_Exercises___05._Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfClicks = int.Parse(Console.ReadLine());
            string message = "";

            for (int i = 0; i < numberOfClicks; i++)
            {
                string digits = Console.ReadLine();
                int digitLength = digits.Length;
                int digit = int.Parse(digits[0].ToString());
                
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32); // cast to char and call ASCII value
                    continue;
                }
                if (digit == 8 || digit == 9)
                {
                    offset++;
                }
                int letterIndex = offset + digitLength - 1;
                message += (char)(letterIndex + 97); 
            }
            Console.WriteLine(message);

        }
    }
}
