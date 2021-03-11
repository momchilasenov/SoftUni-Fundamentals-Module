using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _1._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string pattern = @"^.{20}$";

            for (int i = 0; i < tickets.Length; i++)
            {
                string currentTicket = tickets[i].Trim();

                Regex regex = new Regex(pattern);
                Match match = regex.Match(currentTicket);

                if (match.Success)
                {
                    int leftStreak = 1;
                    int rightStreak = 1;

                    int leftMaxStreak = 0;
                    int rightMaxStreak = 0;

                    char leftMaxSymbol = (char)0;
                    char rightMaxSymbol = (char)0;
                    char currentSymbol = (char)0;

                    //Left half
                    string leftString = match.Value.Substring(0, 10);
                    string rightString = match.Value.Substring(10, 10);

                    for (int j = 1; j < leftString.Length; j++)
                    {
                        if (leftString[j] == '$'
                             || leftString[j] == '@'
                             || leftString[j] == '^'
                             || leftString[j] == '#')
                        {
                            currentSymbol = leftString[j];

                            if (currentSymbol == leftString[j - 1])
                            {
                                leftStreak++;
                            }
                            else
                            {
                                leftStreak = 1;
                            }

                            if (leftStreak > leftMaxStreak)
                            {
                                leftMaxStreak = leftStreak;
                                leftMaxSymbol = currentSymbol;
                            }
                        }
                        else
                        {
                            leftStreak = 0;
                        }
                    }

                    for (int k = 1; k < rightString.Length; k++)
                    {
                        if (rightString[k] == '$'
                             || rightString[k] == '@'
                             || rightString[k] == '^'
                             || rightString[k] == '#')
                        {
                            currentSymbol = rightString[k];

                            if (currentSymbol == rightString[k - 1])
                            {
                                rightStreak++;
                            }
                            else
                            {
                                rightStreak = 1;
                            }

                            if (rightStreak > rightMaxStreak)
                            {
                                rightMaxStreak = rightStreak;
                                rightMaxSymbol = currentSymbol;
                            }
                        }
                        else
                        {
                            rightStreak = 0;
                        }
                    }

                    if (leftMaxSymbol == rightMaxSymbol)
                    {
                        if (rightMaxStreak >= 6
                            && rightMaxStreak <= 10
                            && leftMaxStreak >= 6
                            && leftMaxStreak <= 10)
                        {
                            if (rightMaxStreak == 10 && leftMaxStreak == 10)
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - 10{rightMaxSymbol} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{currentTicket}\" - {Math.Min(rightMaxStreak, leftMaxStreak)}{rightMaxSymbol}");
                            }

                        }

                        else
                        {
                            Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                        }
                    }

                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
