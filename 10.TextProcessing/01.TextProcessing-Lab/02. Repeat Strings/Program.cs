using System;
using System.Linq;


namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = Console.ReadLine()
                .Split()
                .ToArray();

            int currentLength = 0;
            string result = string.Empty;
            string partial = string.Empty;

            for (int i = 0; i < stringArray.Length; i++)
            {
                currentLength = stringArray[i].Length;

                for (int j = 0; j < currentLength; j++)
                {
                    result += stringArray[i];
                }
            }
            Console.WriteLine(result);

        }
    }
}
