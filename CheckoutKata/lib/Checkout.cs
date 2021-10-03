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
