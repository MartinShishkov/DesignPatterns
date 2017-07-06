using System;
using Patterns.Strategy.Common;

namespace Patterns.Strategy.Problem
{
    /*
        Adding a new shipping method to the system
        will require us to modify this SimpleShippingCostCalculatorService
        class. This violates the Open/Closed principle. Also if we 
        would like to change the algorithms for each calculation, 
        we'd have to make sure that every algorithm doesn't affect
        the others due to some shared state.
    */

    public class SimpleShippingCostCalculatorService :
        IShippingCostCalculatorService
    {
        public decimal CalculateCost(Order order)
        {
            switch (order.ShippingMethod)
            {
                case ShippingMethod.FedEx:
                    return CalculateCostForFedEx(order);
                case ShippingMethod.Ups:
                    return CalculateCostForUps(order);
                case ShippingMethod.Speedy:
                    return CalculateCostForSpeedy(order);
                default:
                    throw new NotSupportedException("Shipping method is not supported");
            }
        }

        private decimal CalculateCostForFedEx(Order order)
        {
            return order.Items * 3.0M;
        }

        private decimal CalculateCostForUps(Order order)
        {
            return order.Items * 4.25M;
        }

        private decimal CalculateCostForSpeedy(Order order)
        {
            return order.Items * 5.0M;
        }
    }
}