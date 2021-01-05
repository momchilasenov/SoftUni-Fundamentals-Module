using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0; 

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            else if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            else if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.5;
                }
            }

            double totalPrice = numberOfPeople * price;

            if (typeOfGroup == "Students" && numberOfPeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (typeOfGroup == "Business" && numberOfPeople >= 100)
            {
                totalPrice -= price * 10;
            }
            else if (typeOfGroup == "Regular" && numberOfPeople >= 10 && numberOfPeople<=20)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");



        }
    }
}
