using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata.lib
{
    /// <summary>
    /// Basket object
    /// </summary>
    public class Basket
    {          
        private List<BasketItem> BasketItems { get; set; }

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
            return true;   
        }
    }
}
