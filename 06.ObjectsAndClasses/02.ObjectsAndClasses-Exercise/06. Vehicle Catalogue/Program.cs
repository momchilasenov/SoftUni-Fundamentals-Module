using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<Vehicle> vehicles = new List<Vehicle>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputs = input.Split().ToArray();
                string typeOfVehicle = inputs[0];
                string model = inputs[1];
                string color = inputs[2];
                double horsePower = double.Parse(inputs[3]);

                Vehicle vehicle = new Vehicle(typeOfVehicle, model, color, horsePower);

                vehicles.Add(vehicle);
            }
            string modelInput = String.Empty;
            while ((modelInput=Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.FirstOrDefault(x => x.Model == modelInput).ToString());//override ToString method
            }

            var cars = vehicles.FindAll(x => x.Type == "car"); //we put all cars in a list
            var carsHorsepower = cars.Sum(y => y.HorsePower); //we take only the sum of horsepowers
            var carsAverage = carsHorsepower / cars.Count; // we find the average

            List<Vehicle> trucks = vehicles.FindAll(x => x.Type == "truck");
            double trucksHorsepower = trucks.Sum(y => y.HorsePower);
            double trucksAverage = trucksHorsepower / trucks.Count;

            if (cars.Count == 0)
            {
                carsAverage = 0;
            }
            else if (trucks.Count == 0)
            {
                trucksAverage = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAverage:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAverage:f2}.");
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }

        public Vehicle(string type, string model, string color, double horsePower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsePower;
        }

        public override string ToString()
        {
            StringBuilder buildString = new StringBuilder();
           
            if (this.Type == "car")
            {
                buildString.AppendLine($"Type: Car");
            }
            else if (this.Type == "truck")
            {
                buildString.AppendLine($"Type: Truck");
            }
            
            buildString.AppendLine($"Model: {this.Model}");
            buildString.AppendLine($"Color: {this.Color}");
            buildString.AppendLine($"Horsepower: {this.HorsePower}");

            return buildString.ToString().TrimEnd();

        }
    }
}
