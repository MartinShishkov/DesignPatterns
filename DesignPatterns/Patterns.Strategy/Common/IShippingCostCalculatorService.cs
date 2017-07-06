namespace Patterns.Strategy.Common
{
    public interface IShippingCostCalculatorService
    {
        decimal CalculateCost(Order order);
    }
}