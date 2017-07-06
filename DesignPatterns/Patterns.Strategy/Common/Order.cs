namespace Patterns.Strategy.Common
{
    public class Order
    {
        public Order(int items, ShippingMethod shippingMethod)
        {
            Items = items;
            ShippingMethod = shippingMethod;
        }

        public ShippingMethod ShippingMethod { get; }
        public int Items { get; set; }
    }
}