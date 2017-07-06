namespace Patterns.Strategy.Common
{
    public class Context
    {
        public Order CreateOrder(int numberOfItems, ShippingMethod method)
        {
            return new Order(numberOfItems, method);
        }
    }
}