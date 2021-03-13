using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. read the input string 
            //2. Use a stringbuilder so you can modify the string
            //2. start going through the string char by char
            //3. compare the char in position n with the one in position n+1
            //3.1. if equal -> remove n+1 char -> reset the loop variable to i--
            //4. when finished with the stringbuilder chars end the loop
            //5. convert the sb to string and print it 

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
