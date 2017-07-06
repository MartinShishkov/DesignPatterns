using Patterns.Strategy.Common;

namespace Patterns.Strategy.Solution
{
    public class SpeedyCostCalculationStrategy :
        IShippingCostCalculationStrategy
    {
        public decimal GetCostFor(Order order)
        {
            return order.Items * 5.0M;
        }
    }
}