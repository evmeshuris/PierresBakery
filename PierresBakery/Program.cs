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
            //Console.WriteLine(Pastry.ShowDeal());
            Console.WriteLine("How many loafs of bread you would like to buy?");
            string breadAnswer = Console.ReadLine();
            //breadAnser = 2
            //Console.WriteLine("How many pastries you would like to buy?");
            //string pastriesAnswer = Console.ReadLine();
            // pa=5

            bread.Quantity = Int32.Parse(breadAnswer);

            Console.WriteLine(bread.ShowTotal());
            //pastry.Quantity = pastryAnswer;
            //Console.WriteLine(pastry.ShowTotal());


        }

    }
}

