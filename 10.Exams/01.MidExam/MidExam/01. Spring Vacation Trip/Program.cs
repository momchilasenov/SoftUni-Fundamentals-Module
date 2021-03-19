using System;

namespace _01._Spring_Vacation_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfTrip = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double fuelPricePerKilometer = double.Parse(Console.ReadLine());
            double foodPerPersonPerDay = double.Parse(Console.ReadLine());
            double roomPricePerPersonPerDay = double.Parse(Console.ReadLine());

            double totalFoodPrice = people * daysOfTrip * foodPerPersonPerDay;
            double totalHotelPrice = people * daysOfTrip * roomPricePerPersonPerDay;
            if (people > 10)
            {
                totalHotelPrice -= totalHotelPrice * 0.25;
            }
            double totalExpenses = totalFoodPrice + totalHotelPrice;

            for (int i = 1; i <= daysOfTrip; i++)
            {
                double traveledDistance = double.Parse(Console.ReadLine());
                double travelExpenses = traveledDistance * fuelPricePerKilometer;
                totalExpenses += travelExpenses;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    totalExpenses += totalExpenses * 0.4;
                }
                if (i % 7 == 0)
                {
                    totalExpenses -= totalExpenses / people;
                }

                if (totalExpenses > budget)
                {
                    Console.WriteLine($"Not enough money to continue the trip. " +
                        $"You need {Math.Abs(totalExpenses - budget):f2}$ more.");
                    return;
                }

            }
            Console.WriteLine($"You have reached the destination. You have {budget - totalExpenses:f2}$ budget left.");

        }
    }
}
