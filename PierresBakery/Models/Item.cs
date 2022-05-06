
namespace PierresBakery.Models
{
    public class Bread
    {
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Bread(int price)
        {
            Price = price;
        }

        public int TotalBreadPrice()
        {
            if (Quantity < 3)
            {
                return Quantity * Price;
            }
            else
            {
                //return -(Math.Round(Quantity, 0) / 3) * 5 + Quantity * 5;
                int cntDisc = Quantity / 3;
                return (Quantity * Price) - (cntDisc * Price);
            }
        }

        public override string ToString()
        {
            return $"${Price}";
        }

        public string ShowTotal()
        {
            return $"Here is your total for bread: ${TotalBreadPrice}";
        }

        public string ShowDeal()
        {
            return $"Buy 2 loafs get 1 free!";
        }
    }

    public class Pastry
    {
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Pastry(int price)
        {
            Price = price;
        }
        public int TotalPastryPrice()
        {
            //if (pastriesAnswer < 3)
            //{
            //    pastryTotal = pastriesAnswer * 2;
            //}
            //if (pastriesAnswer >= 3)
            //{
            //    pastryTotal = -(Math.Round(pastriesAnswer, 0) / 3) + pastriesAnswer * 2;

            //}
            //return pastryTotal;

            if (Quantity < 3)
            {
                return Quantity * Price;
            }
            else
            {
                //return -(Math.Round(Quantity, 0) / 3) * 5 + Quantity * 5;
                int cntDisc = Quantity / 3;
                return (Quantity * Price) - cntDisc;
            }
        }
        public override string ToString()
        {
            return $"${Price}";
        }

        public string ShowTotal()
        {
            return "Here is your total for pastries: " + TotalPastryPrice().ToString();
        }

        public string ShowDeal()
        {
            return $"Each third pastry with 1$ off!";
        }
    }
}