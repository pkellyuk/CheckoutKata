using System;
using System.Collections.Generic;

namespace CheckoutKata.lib
{
    /// <summary>
    /// Basket object
    /// </summary>
    public class Basket
    {
        private decimal TotalCost;
        private List<BasketItem> BasketItems;

        public Basket()
        {
            BasketItems = new List<BasketItem>();
        }

        public List<BasketItem> GetAllItems()
        {
            return BasketItems;
        }

        public bool AddItem(BasketItem item)
        {
            BasketItems.Add(item);
            ApplyPromotions();
            CalculateTotal();
            return true;   
        }

        public decimal GetTotalCost()
        {
            return TotalCost;
        }

        private void CalculateTotal()
        {
            TotalCost = 0m;

            foreach(BasketItem basketItem in BasketItems)
            {
                if(basketItem.IsPromoApplied() == true)
                {
                    TotalCost += basketItem.GetPromoPrice();
                }
                else
                {
                    TotalCost += basketItem.GetUnitPrice() * basketItem.GetQuantity();
                }
            }
        }

        private void ApplyPromotions()
        {
            foreach (BasketItem basketItem in BasketItems)
            {
                if (basketItem.GetQuantity() == 3 && basketItem.GetSKU() == "B")
                {
                    Console.WriteLine("applying promo 3 for 40");
                    basketItem.SetPromoPrice(40.00m);
                }

                if(basketItem.GetQuantity() == 2 && basketItem.GetSKU() == "D")
                {
                    Console.WriteLine("applying promo 25% off every two");
                    decimal promoPrice = (basketItem.GetUnitPrice() * (decimal)basketItem.GetQuantity()) * (decimal)0.75;
                    basketItem.SetPromoPrice(promoPrice);
                }
            }
        }
    }
}
