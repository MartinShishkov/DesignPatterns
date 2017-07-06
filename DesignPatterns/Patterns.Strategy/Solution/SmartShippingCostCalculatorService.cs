using System;
using Patterns.Strategy.Common;

namespace Patterns.Strategy.Solution
{
    /*
        We have now separated concerns:
        The algorithms for calculating shipping costs
        no longer depend on the service that needs them!

        Moreover, there is no possible way that we get
        a NotSupportedException in contrast with the 
        SimpleShippingCostCalculatorService.
    */

    public class SmartShippingCostCalculatorService : 
        IShippingCostCalculatorService
    {
        private readonly IShippingCostCalculationStrategy _strategy;

        public SmartShippingCostCalculatorService(
            IShippingCostCalculationStrategy strategy)
        {
            _strategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        }

        public decimal CalculateCost(Order order)
        {
            return this._strategy.GetCostFor(order);
        }
    }
}