using System;

namespace More_Exercises___04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello -> olleH

            string word = Console.ReadLine();

            int length = word.Length;
            string reversed = "";

            for (int i=length-1; i>=0; i--)
            {
                reversed += word[i].ToString();

            }
            Console.WriteLine(reversed);
        }
    }
}
