
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

        public int TotalPrice()
        {
            if (Quantity < 3)
            {
                return Quantity * Price;
            }
            else
            {
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
            return $"Here is your total for bread: ${TotalPrice()}";
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
        public int TotalPrice()
        {
            if (Quantity < 3)
            {
                return Quantity * Price;
            }
            else
            {
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
            return $"Here is your total for pastries:  ${TotalPrice()}";
        }

        public string ShowDeal()
        {
            return $"Each third pastry with 1$ off!";
        }
        
    }
    
}