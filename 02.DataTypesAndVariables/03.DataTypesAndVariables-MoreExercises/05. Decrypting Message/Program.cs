using System;

namespace ME___05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i=0; i<n; i++)
            {
                char letter = char.Parse(Console.ReadLine()); //R

                int decryptedLetter = (int)letter + key; //136
                message += (char)decryptedLetter;
            }
            Console.WriteLine(message);


        }
    }
}
