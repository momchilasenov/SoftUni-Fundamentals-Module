using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = string.Empty;

            Dictionary<string, int> mineData = new Dictionary<string, int>();

            while ((resource = Console.ReadLine()) == "stop" == false) //trufi
            {
                int quantity = int.Parse(Console.ReadLine());

                if (mineData.ContainsKey(resource))
                {
                    mineData[resource] += quantity;
                }
                else
                {
                    mineData.Add(resource, quantity);
                }
            }
            foreach(var element in mineData)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }
        }
    }
}
