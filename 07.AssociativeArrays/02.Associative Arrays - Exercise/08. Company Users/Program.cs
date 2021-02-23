using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] data = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string company = data[0].Trim();
                string worker = data[1].Trim();

                if (companies.ContainsKey(company))
                {
                    if (!companies[company].Contains(worker))
                    {
                        companies[company].Add(worker);
                    }
                }
                else
                {
                    companies.Add(company, new List<string>());
                    companies[company].Add(worker);
                }
            }
            foreach (KeyValuePair<string, List<string>> company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{company.Key}");
                foreach (string worker in company.Value)
                {
                    Console.WriteLine($"-- {worker}");
                }

            }
        }
    }
}
