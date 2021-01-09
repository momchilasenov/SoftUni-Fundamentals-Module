using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            int asciiValue = (int)letter;
            if (asciiValue >= 65 && asciiValue <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else if (asciiValue>= 97 && asciiValue<= 122)
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
