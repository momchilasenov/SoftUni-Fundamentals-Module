using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] data = input.Split();

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                decimal itemPrice = decimal.Parse(data[3]);

                Item item = new Item();
                item.Name = itemName;
                item.Price = itemPrice;

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Quantity = itemQuantity;
                box.Item = item;

                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach(Box currentBox in boxes.OrderByDescending(x=>x.PricePerBox)) //using lambda
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - ${currentBox.Item.Price:f2}: {currentBox.Quantity}");
                Console.WriteLine($"-- ${currentBox.PricePerBox:f2}");
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Box
    {
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerBox
        {
            get
            {
                return Item.Price * Quantity;
            }
            /*
            алтернативен запис: 
            public decimal PricePerBox
                    => Item.Price*Quantity; 
            */

        }
    }
}
