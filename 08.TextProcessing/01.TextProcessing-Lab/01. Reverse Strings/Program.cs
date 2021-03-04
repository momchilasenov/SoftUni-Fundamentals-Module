using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string reversed = string.Empty;

            while (word != "end")
            {
                for (int i = word.Length-1; i >= 0; i--)
                {
                    reversed += word[i];
                }
                Console.WriteLine($"{word} = {reversed}");
                word = Console.ReadLine();
                reversed = string.Empty;
            }
            
        }
    }
}
