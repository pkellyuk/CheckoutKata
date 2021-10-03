using CheckoutKata.stock;

namespace CheckoutKata.lib
{
    /// <summary>
    /// BasketItem object
    /// </summary>
    public class BasketItem
    {
        private StockItem StockItem;
        private int Quantity;
        private decimal PromoPrice;
        private bool PromoApplied;

        public string GetSKU()
        {
            return StockItem.GetSKU();
        }

        public decimal GetPromoPrice()
        {
            return PromoPrice;
        }

        public void SetPromoPrice(decimal promoPrice)
        {
            PromoPrice = promoPrice;
            PromoApplied = true;
        }

        public bool IsPromoApplied()
        {
            return PromoApplied;
        }

        public decimal GetUnitPrice()
        {
            return StockItem.GetUnitPrice();
        }

        public int GetQuantity()
        {
            return Quantity;
        }

        public BasketItem(StockItem stockItem, int quantity)
        {
            StockItem = stockItem;
            Quantity = quantity;
        }
    }
}
