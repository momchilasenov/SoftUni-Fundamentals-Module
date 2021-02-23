using System;

namespace _03.MOBAChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "ab";
            string second = "aaaaa";

            while (true)
            {
                number += "abcde";
                second += number;
                Console.WriteLine(second);
            }
        }
    }
}
