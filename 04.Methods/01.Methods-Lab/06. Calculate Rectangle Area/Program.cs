using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            //Console.WriteLine(RectangleArea(width, height));
            int area = RectangleArea(width, height);
            Console.WriteLine(area);

        }
        static int RectangleArea (int width, int height)
        {
            return width * height;
        }
    }
}
