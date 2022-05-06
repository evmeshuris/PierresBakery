using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TotalPriceBread_ReturnsTotalPriceOfBreadWithDiscount()
        {
            Bread bread = new(5)
            {
                Quantity = 4
            };
            Assert.AreEqual(15, bread.TotalPrice());
        }
        [TestMethod]
        public void TotalPricePastry_ReturnsTotalPriceOfPastryWithDiscount()
        {
            Pastry pastry = new(2)
            {
                Quantity = 7
            };
            Assert.AreEqual(12, pastry.TotalPrice());
        }
        [TestMethod]
        public void FinalPrice_ReturnsFinalPriceWithDiscount()
        {
            Pastry pastry = new(2)
            {
                Quantity = 7
            };
            Bread bread = new(5)
            {
                Quantity = 4
            };
            Assert.AreEqual(27, pastry.TotalPrice() + bread.TotalPrice());
        }
        [TestMethod]
        public void TotalPriceBread_ReturnsTotalPriceOfBread_IfQuantatyLessThanThree()
        {
            Bread bread = new(5)
            {
                Quantity = 2
            };
            Assert.AreEqual(10, bread.TotalPrice());
        }
        [TestMethod]
        public void TotalPricePastry_ReturnsTotalPriceOfPastry_IfQuantatyLessThanThree()
        {
            Pastry pastry = new(2)
            {
                Quantity = 2
            };
            Assert.AreEqual(4, pastry.TotalPrice());
        }
    }
}