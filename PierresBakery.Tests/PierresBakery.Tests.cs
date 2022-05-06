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
    [TestMethod]
    public void TotalPricePastry_ReturnsTotalPriceOfPastry()
    {
        Pastry pastry = new Pastry(2);
        pastry.Quantity = 7;
        Assert.AreEqual(12, pastry.TotalPrice());
    }
    [TestMethod]
    public void FinalPrice_ReturnsFinalPrice()
    {
        Pastry pastry = new Pastry(2);
        Bread bread = new Bread(5);
        pastry.Quantity = 7;
        bread.Quantity = 4;
        Assert.AreEqual(27, pastry.TotalPrice() + bread.TotalPrice());
    }
    [TestMethod]
    public void TotalPriceBread_ReturnsTotalPriceOfBread_IfQuantatyLessThanThree()
    {
        Bread bread = new Bread(5);
        bread.Quantity = 2;
        Assert.AreEqual(10, bread.TotalPrice());
    }
    [TestMethod]
    public void TotalPricePastry_ReturnsTotalPriceOfPastry_IfQuantatyLessThanThree()
    {
        Pastry pastry = new Pastry(2);
        pastry.Quantity = 2;
        Assert.AreEqual(4, pastry.TotalPrice());
    }
}
