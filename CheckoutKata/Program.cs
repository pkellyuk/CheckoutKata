using System;
using CheckoutKata.lib;
using CheckoutKata.stock;

namespace CheckoutKata
{
    class Program
    {
        static void Main(string[] args)
        {
            AddItemToBasket();
            TestPromo_3_for_40();
            TestPromo_25pct_off();
        }

        static void TestPromo_25pct_off()
        {
            Console.WriteLine("** starting test TestPromo_25pct_off()");

            // get a stock item with a quantity of 2
            StockItem stockItem = new StockItem("D", 2);

            // create a basket item
            BasketItem basketItem = new BasketItem(stockItem, 2);

            // Create the basket
            Basket basket = new Basket();

            // add stock item to basket
            if (basket.AddItem(basketItem) != true)
            {
                Console.WriteLine("Failed to add item to basket with quantity: " + basketItem.GetQuantity());
                return;
            }

            Console.WriteLine("Item added to Basket");
            ShowBasketContents(basket);
        }

        static void TestPromo_3_for_40()
        {
            Console.WriteLine("** starting test TestPromo_3_for_40()");

            // get a stock item with a quantity of 3
            StockItem stockItem = new StockItem("B", 3);

            // create a basket item
            BasketItem basketItem = new BasketItem(stockItem, 3);

            // Create the basket
            Basket basket = new Basket();

            // add stock item to basket
            if (basket.AddItem(basketItem) != true)
            {
                Console.WriteLine("Failed to add item to basket with quantity: " + basketItem.GetQuantity());
                return;
            }

            Console.WriteLine("Item added to Basket");
            ShowBasketContents(basket);
        }

        static void AddItemToBasket()
        {
            Console.WriteLine("** starting test AddItemToBasket()");

            // get a stock item with a quantity of 1
            StockItem stockItem = new StockItem("A", 1);

            // create a basket item
            BasketItem basketItem = new BasketItem(stockItem, 1);

            // Create the basket
            Basket basket = new Basket();

            // add stock item to basket
            if (basket.AddItem(basketItem)!=true)
            {
                Console.WriteLine("Failed to add item to basket with quantity: " + basketItem.GetQuantity());
                return;
            }

            Console.WriteLine("Item added to Basket");
            ShowBasketContents(basket);            
        }

        static void ShowBasketContents(Basket basket)
        {
            foreach(BasketItem basketItem in basket.GetAllItems())
            {
                Console.WriteLine("StockItem " + basketItem.GetSKU() + 
                    " is in basket with quantity:" + basketItem.GetQuantity());
            }

            Console.WriteLine("Basket total cost: " + basket.GetTotalCost() + "\r\n");
        }
    }
}
