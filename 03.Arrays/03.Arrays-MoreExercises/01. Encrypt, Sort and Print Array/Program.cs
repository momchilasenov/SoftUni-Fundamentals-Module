using System;
using System.Linq;

namespace More_Exercises_01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int[] values = new int[n];
            int counter = -1;

            for (int x = 1; x <= n; x++)
            {
                string name = Console.ReadLine();
                int currentLength = name.Length;

                int currentVowelValue = 0; // за всяка нова дума зануляваме настоящата стойност
                int totalVowelsSum = 0;
                int currentConsonantValue = 0;
                int totalConsonantSum = 0;
                int totalNameSum = 0;

                for (int i = 0; i < currentLength; i++)
                {
                    if (vowels.Contains(name[i]))
                    {
                        currentVowelValue = ((int)name[i]) * currentLength;
                        totalVowelsSum += currentVowelValue;
                    }
                    else
                    {
                        currentConsonantValue = (int)name[i] / currentLength;
                        totalConsonantSum += currentConsonantValue;
                    }

                }
                counter++;
                totalNameSum = totalConsonantSum + totalVowelsSum;
                for (int i = counter; i <= counter; i++)
                {
                    values[i] = totalNameSum;
                }

            }

            values = values.OrderBy(x => x).ToArray();

            Console.WriteLine(String.Join(Environment.NewLine, values));


        }

    }

}

