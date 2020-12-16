using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    //class Box
    //{
    //    public Box(string serialNumber, Item item, int itemQuantity)
    //    {
    //        SerialNumber = serialNumber;
    //        Item = item;
    //        ItemQuantity = itemQuantity;
    //    }

    //    public string SerialNumber { get; set; }

    //    public Item Item { get; set; }

    //    public int ItemQuantity { get; set; }

    //    public decimal PriceForBox
    //        => Item.Price * ItemQuantity;
    //}

    //class Item
    //{
    //    public Item(string name, decimal price)
    //    {
    //        Name = name;
    //        Price = price;
    //    }

    //    public string Name { get; set; }

    //    public decimal Price { get; set; }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Box> boxes = new List<Box>();

            while (input != "end")
            {
                string[] inputInfo = input.Split();

                string serialNumber = inputInfo[0];
                string itemName = inputInfo[1];
                int itemQuantity = int.Parse(inputInfo[2]);
                decimal itemPrice = decimal.Parse(inputInfo[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);

                boxes.Add(box);

                input = Console.ReadLine();
            }
            var resultSet = boxes.OrderByDescending(x => x.PriceForBox).ToList();

            foreach (var currentBox in resultSet)
            {
                Console.WriteLine(currentBox.SerialNumber);
                Console.WriteLine($"-- {currentBox.Item.Name} - " +
                    $"${currentBox.Item.Price:f2}: {currentBox.ItemQuantity}");
                Console.WriteLine($"-- ${currentBox.PriceForBox:f2}");
            }












        }
    }
}
