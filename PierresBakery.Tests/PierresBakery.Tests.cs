using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TotalPriceBread_ReturnsTotalPriceOfBread()
    {
        Bread bread = new Bread(5);
        bread.Quantity = 4;
        Assert.AreEqual(15, bread.TotalPrice());
    }
    //[TestMethod]
    //public void TotalPricePastry_ReturnsTotalPriceOfPastry()
    //{
    //    Pastry pastry = new Pastry(8);
    //    Assert.AreEqual(14, pastry.TotalPrice());
    //}
}
