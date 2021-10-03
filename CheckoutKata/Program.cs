using System;
using CheckoutKata.lib;
using CheckoutKata.stock;

namespace CheckoutKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling AddItemToBasket()");
            AddItemToBasket();

        }

        static void AddItemToBasket()
        {
            // get a stock item
            StockItem stockItem = new StockItem("A");

            // add stock item to basket
            BasketItem basketItem = new BasketItem(stockItem);

            Basket basket = new Basket();
            if(basket.AddItem(basketItem)!=true)
            {
                Console.WriteLine("Failed to add item to basket");
                return;
            }

            Console.WriteLine("Item added to Basket");
            ShowBasketContents(basket);
        }

        static void ShowBasketContents(Basket basket)
        {
            foreach(BasketItem basketItem in basket.GetAllItems())
            {
                Console.WriteLine(basketItem.StockItem.SKU);
            }
        }
    }
}
