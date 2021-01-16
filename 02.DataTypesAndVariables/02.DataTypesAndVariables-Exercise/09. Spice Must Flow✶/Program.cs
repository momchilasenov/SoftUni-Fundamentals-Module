using System;

namespace _09._Spice_Must_Flow_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sourceYield = int.Parse(Console.ReadLine());
            int extractedSpice = 0;
            int dayCounter = 0;

            while (sourceYield >= 100)
            {
                extractedSpice += sourceYield;
                extractedSpice -= 26;
                sourceYield -= 10;
                dayCounter++;

                if (extractedSpice <= 0)
                {
                    extractedSpice = 0;
                }

                if (sourceYield < 100)
                {
                    extractedSpice -= 26;
                    break;
                }
            }
            Console.WriteLine(dayCounter);
            Console.WriteLine(extractedSpice);
        }
    }
}
