using System;

namespace _01._Easter_Cozonacs
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggsPrice = flourPrice * 0.75;
            double milkPricePerLeter = flourPrice * 1.25;
            double milkPrice = milkPricePerLeter / 4;

            double totalPricePerCozonac = flourPrice + eggsPrice + milkPrice;
            int cozonacsCounter = 0;
            int coloredEggs = 0;
            int eggsToRemove = 0;

            while (budget-totalPricePerCozonac >= 0)
            {
                cozonacsCounter++;
                budget -= totalPricePerCozonac;
                coloredEggs += 3;
                if (cozonacsCounter % 3 == 0)
                {
                    eggsToRemove = cozonacsCounter - 2;
                    coloredEggs -= eggsToRemove;
                }
            }
            Console.WriteLine($"You made {cozonacsCounter} cozonacs! Now you have {coloredEggs} eggs and {budget:f2}BGN left.");
        }
    }
}
