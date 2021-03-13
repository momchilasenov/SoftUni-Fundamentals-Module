using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programming is cool!

            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            
            for (int i = 0; i < message.Length; i++)
            {
                char currentChar = message[i];
                int charToInt = (int)currentChar;
                int newChar = charToInt + 3;
                sb.Append((char)newChar);
            }
            Console.WriteLine(sb);
        }
    }
}
