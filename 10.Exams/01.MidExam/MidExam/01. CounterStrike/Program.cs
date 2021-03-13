using System;

namespace _01._CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine()); //100

            string command = Console.ReadLine();
            int wonBattles = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command); //10

                if (distance <= initialEnergy)
                {
                    wonBattles++;
                    initialEnergy -= distance;
                    if (wonBattles % 3 == 0)
                    {
                        initialEnergy += wonBattles;
                    }
                }
                else if (distance > initialEnergy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wonBattles} won battles and {initialEnergy} energy");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {wonBattles}. Energy left: {initialEnergy}");
            }
        }
    }
}
