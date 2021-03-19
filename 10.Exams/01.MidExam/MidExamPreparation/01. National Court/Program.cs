using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployeeEfficiency = int.Parse(Console.ReadLine()); //5
            int secondEmployeeEfficiency = int.Parse(Console.ReadLine()); //4
            int thirdEmployeeEfficiency = int.Parse(Console.ReadLine()); //3

            int totalPeopleCount = int.Parse(Console.ReadLine());

            int totalEfficiency = firstEmployeeEfficiency + secondEmployeeEfficiency + thirdEmployeeEfficiency;
            int hoursCount = 0;

            while (totalPeopleCount > 0)
            {
                hoursCount++;
                if (hoursCount % 4 == 0)
                {
                    continue;
                }

                totalPeopleCount -= totalEfficiency;
                
            }
            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
