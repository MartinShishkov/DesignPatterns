using Patterns.Strategy.Common;

namespace Patterns.Strategy.Solution
{
    public class FedExCostCalculationStrategy :
        IShippingCostCalculationStrategy
    {
        public decimal GetCostFor(Order order)
        {
            return order.Items * 3.0M;
        }
    }
}