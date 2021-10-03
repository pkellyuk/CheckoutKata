using System.Collections.Generic;
using CheckoutKata.stock;

namespace CheckoutKata.lib
{
    /// <summary>
    /// BasketItem object
    /// </summary>
    public class BasketItem
    {
        public StockItem StockItem { get; set; }

        public BasketItem(StockItem stockItem)
        {
            StockItem = stockItem;
        }
    }
}
