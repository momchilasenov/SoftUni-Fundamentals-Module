using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.NeedForSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string token = Console.ReadLine();
                string[] carInfo = token.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string typeOfCar = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);

                if (!cars.ContainsKey(typeOfCar))
                {
                    cars.Add(typeOfCar, new Car() { Mileage = mileage, Fuel = fuel });
                }
            }

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] commands = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string car = commands[1];

                if (cars.ContainsKey(car))
                {
                    if (command == "Drive")
                    {
                        int distance = int.Parse(commands[2]);
                        int fuel = int.Parse(commands[3]);

                        if (cars[car].Fuel < fuel)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[car].Mileage += distance;
                            cars[car].Fuel -= fuel;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        }

                        if (cars[car].Mileage >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);
                        }
                    }

                    else if (command == "Refuel")
                    {
                        int fuel = int.Parse(commands[2]);

                        if (cars[car].Fuel + fuel > 75)
                        {
                            fuel = 75 - cars[car].Fuel;
                        }

                        cars[car].Fuel += fuel;

                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }

                    else if (command == "Revert")
                    {
                        int kilometers = int.Parse(commands[2]);

                        if (cars[car].Mileage - kilometers < 10000)
                        {
                            cars[car].Mileage = 10000;
                        }
                        else
                        {
                            cars[car].Mileage -= kilometers;
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                    }
                }

                input = Console.ReadLine();
            }
            cars = cars
                .OrderByDescending(m => m.Value.Mileage)
                .ThenBy(n => n.Key)
                .ToDictionary(a => a.Key, b => b.Value);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");

            }

        }
    }

    public class Car
    {
        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }
}
