using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double length, width, height, volume = 0;

            length = double.Parse(Console.ReadLine());
            Console.Write($"Length: ");

            width = double.Parse(Console.ReadLine());
            Console.Write($"Width: ");

            height = double.Parse(Console.ReadLine());
            Console.Write($"Height: ");

            volume = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
