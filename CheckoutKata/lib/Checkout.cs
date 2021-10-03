using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutKata.lib;

namespace CheckoutKata.lib
{
    /// <summary>
    /// Checkout object
    /// </summary>
    public class Checkout
    {
        private Basket _basket;

        public Checkout(Basket basket)
        {
            _basket = basket;
        }
    }

}
