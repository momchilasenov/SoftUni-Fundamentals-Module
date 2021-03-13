using System;
using System.Text;
using System.Linq;


namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int lastSlash = input.LastIndexOf("\\");
            string substring = input.Substring(lastSlash + 1);

            string[] split = substring.Split('.');

            Console.WriteLine($"File name: {split[0]}");
            Console.WriteLine($"File extension: {split[1]}");
        }
    }
}
