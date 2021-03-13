using System;
using System.Linq;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
          

            double studentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());
            int maxBonus = int.MinValue;
            int maxAttendance = int.MinValue;

            if (studentsCount == 0 || lecturesCount == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            for (int i = 1; i <= studentsCount; i++)
            {
                int currentAttendance = int.Parse(Console.ReadLine()); //28
                double totalBonus = Math.Ceiling(currentAttendance * 1.0 / lecturesCount * (5 + initialBonus));

                if (totalBonus > maxBonus)
                {
                    maxBonus = (int)totalBonus;
                    maxAttendance = currentAttendance;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");

        }
    }
}

