using System;

namespace _10._Rage_Expenses_
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = lostGames / 2;
            int trashedMouse = lostGames / 3;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 6 == 0)
                {
                    trashedKeyboard++;
                }
                if (i % 12 == 0)
                {
                    trashedDisplay++;
                }

            }

            double total = (trashedHeadset * headsetPrice) + (trashedKeyboard * keyboardPrice) + (trashedMouse * mousePrice) + (trashedDisplay * displayPrice);

            Console.WriteLine($"Rage expenses: {total:f2} lv.");

            Console.WriteLine(totalExpenses);

        }
    }
}
