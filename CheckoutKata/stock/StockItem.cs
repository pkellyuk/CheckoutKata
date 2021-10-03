using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutKata.lib;

namespace CheckoutKata.stock
{
    /// <summary>
    /// StockItem
    /// </summary>
    public class StockItem
    {        
        public string SKU { get; set; }
        public decimal UnitPrice { get; set; }
        public Promotion Promotion { get; set; }

        public StockItem(string sku)
        {
            SKU = sku;
        }

        public decimal GetUnitPrice()
        {
            return UnitPrice;
        }
    }
}
