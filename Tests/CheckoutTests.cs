using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckoutKata;
using CheckoutKata.stock;
using CheckoutKata.lib;

namespace Tests
{
    [TestClass]
    public class CheckoutTests
    {
        [TestMethod]
        public void Test_Discount_D()
        {
            // get a stock item with a quantity of 2
            StockItem stockItem = new StockItem("D", 2);

            // create a basket item
            BasketItem basketItem = new BasketItem(stockItem, 2);

            // Create the basket
            Basket basket = new Basket();
            Assert.IsNotNull(basket);

            // add stock item to basket
            basket.AddItem(basketItem);

            Assert.AreEqual(basket.GetTotalCost(), (decimal)82.50);
        }
    }
}
