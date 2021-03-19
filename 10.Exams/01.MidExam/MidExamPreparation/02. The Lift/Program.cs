using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWaiting = int.Parse(Console.ReadLine());

            int[] seats = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int count = 0;
            int seatsAvailable = 0;


            for (int m = 0; m < seats.Length; m++)
            {
                int peopleWhoGotOn = 0;
                seatsAvailable = 4 - seats[m];
                if (peopleWaiting > 0)
                {
                    if (seatsAvailable != 0 && peopleWaiting >= 4)
                    {
                        peopleWhoGotOn = 4 - seats[m];
                        seats[m] += peopleWhoGotOn;
                        peopleWaiting -= peopleWhoGotOn;
                    }
                    else if (seatsAvailable != 0 && peopleWaiting < 4)
                    {
                        if (peopleWaiting <= seatsAvailable)
                        //3
                        //0 заети
                        {
                            peopleWhoGotOn = peopleWaiting;
                            seats[m] += peopleWaiting;//3   

                            peopleWaiting -= peopleWhoGotOn;
                        }
                        else if (peopleWaiting > seatsAvailable) 
                        {
                            peopleWaiting -= seatsAvailable;
                            seats[m] += seatsAvailable;
                        }

                    }

                    if (seats[m] == 4)
                    {
                        count++;
                    }
                }
            }

            if (peopleWaiting == 0)
            {
                if (count == seats.Length)
                {
                    Console.WriteLine(String.Join(' ', seats));
                }
                else if (count < seats.Length)
                {
                    Console.WriteLine("The lift has empty spots!");
                    Console.WriteLine(String.Join(' ', seats));
                    return;
                }
            }
            else if (peopleWaiting > 0)
            {
                if (count == seats.Length)
                {
                    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
                    Console.WriteLine(String.Join(' ', seats));
                }
            }
        }
    }
}


