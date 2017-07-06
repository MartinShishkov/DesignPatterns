using Patterns.Strategy.Common;

namespace Patterns.Strategy.Solution
{
    public interface IShippingCostCalculationStrategy
    {
        decimal GetCostFor(Order order);
    }
}