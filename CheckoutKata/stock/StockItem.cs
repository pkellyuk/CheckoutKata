using System;

namespace CheckoutKata.stock
{
    /// <summary>
    /// StockItem
    /// </summary>
    public class StockItem
    {
        private string SKU;
        private int Quantity;
        private decimal UnitPrice;

        public StockItem(string sku, int quantity)
        {
            SKU = sku;
            Quantity = quantity;

            switch(sku)
            {
                case "A":
                    UnitPrice = 10.00m;
                    break;
                case "B":
                    UnitPrice = 15.00m;
                    break;
                case "C":
                    UnitPrice = 40.00m;
                    break;
                case "D":
                    UnitPrice = 55.00m;
                    break;
                default:
                    throw new Exception("Unknown SKU");
            }
            Console.WriteLine("Allocating Stock Item " + sku + " with UnitPrice: " + UnitPrice);
        }

        public int GetAvailableQuantity()
        {
            return Quantity;
        }

        public string GetSKU()
        {
            return SKU;
        }

        public decimal GetUnitPrice()
        {
            return UnitPrice;
        }
    }
}
