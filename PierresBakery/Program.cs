using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bread bread = new Bread(5);
            Pastry pastry = new Pastry(2);
            
            Console.WriteLine("Welcome to the Pierre's Bakery");
            Console.WriteLine(bread.ShowDeal());
            Console.WriteLine(pastry.ShowDeal());
            Console.WriteLine("How many loafs of bread you would like to buy?");
            string breadAnswer = Console.ReadLine();
            Console.WriteLine("How many pastries you would like to buy?");
            string pastriesAnswer = Console.ReadLine();

            bread.Quantity = Int32.Parse(breadAnswer);
            pastry.Quantity = Int32.Parse(pastriesAnswer);
            Console.WriteLine(bread.ShowTotal());
            Console.WriteLine(pastry.ShowTotal());
            int finalPrice = pastry.TotalPrice() + bread.TotalPrice();
            Console.WriteLine($"Your final price: $" + finalPrice);

        }

    }
}

