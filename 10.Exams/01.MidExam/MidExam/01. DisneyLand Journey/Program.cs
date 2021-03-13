using System;

namespace _01._DisneyLand_Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double costOfJourney = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());

            double savedMoney = 0;
            double difference = 0;

            for (int i = 1; i <= months; i++)
            {
                if (i % 2 != 0 && i != 1)
                {
                    savedMoney -= savedMoney * 0.16;
                }
                if (i % 4 == 0)
                {
                    savedMoney += savedMoney * 0.25;
                }
                savedMoney += 0.25 * costOfJourney;
            }
            difference = Math.Abs(savedMoney - costOfJourney);
            if (savedMoney >= costOfJourney)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {difference:f2}lv. for souvenirs.");
            }
            else if (savedMoney < costOfJourney)
            {
                Console.WriteLine($"Sorry. You need {difference:f2}lv. more.");
            }
        }
    }
}
