using Patterns.Strategy.Common;

namespace Patterns.Strategy.Solution
{
    public class UpsCostCalculationStrategy : 
        IShippingCostCalculationStrategy
    {
        public decimal GetCostFor(Order order)
        {
            return order.Items * 4.25M;
        }
    }
}