using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);

            for (int i = 0; i < sb.Length-1; i++)
            {
                if (sb[i] == sb[i + 1])
                {
                    sb.Remove(i+1, 1);
                    i--;
                }
            }
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
