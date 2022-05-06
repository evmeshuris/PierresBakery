using PierresBakery.Models;

namespace PierresBakery
{
    public class Program
    {
        public static void Main()
        {
            Bread bread = new(5);
            Pastry pastry = new(2);

            Console.WriteLine("Welcome to the Pierre's Bakery");
            Console.WriteLine(bread.ShowDeal());
            Console.WriteLine(pastry.ShowDeal());
            Console.WriteLine("How many loafs of bread you would like to buy?");
            string? breadAnswer = Console.ReadLine();
            Console.WriteLine("How many pastries you would like to buy?");
            string? pastriesAnswer = Console.ReadLine();

            int parsedBreadAnswer, parsedPastriesAnswer;

            if (!int.TryParse(breadAnswer, out parsedBreadAnswer))
            {
                Console.WriteLine("you are an idiot");
            }

            if (!int.TryParse(pastriesAnswer, out parsedPastriesAnswer))
            {
                Console.WriteLine("you are an idiot");
            }

            bread.Quantity = Math.Abs(parsedBreadAnswer);
            pastry.Quantity = Math.Abs(parsedPastriesAnswer);

            Console.WriteLine(bread.ShowTotal());
            Console.WriteLine(pastry.ShowTotal());
            Console.WriteLine($"Your final price: ${bread.TotalPrice() + pastry.TotalPrice()}");
        }
    }
}

