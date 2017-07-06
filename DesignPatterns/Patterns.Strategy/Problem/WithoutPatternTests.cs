using System;
using NUnit.Framework;
using Patterns.Strategy.Common;

namespace Patterns.Strategy.Problem
{
    [TestFixture]
    public class WithoutPatternTests
    {
        private readonly Context _context = new Context();

        [Test]
        public void Service_Should_Calculate_For_FedEx_Correctly()
        {
            var items = 2;
            var shippingMethod = ShippingMethod.FedEx;

            var order = this._context.CreateOrder(items, shippingMethod);
            var calcService = new SimpleShippingCostCalculatorService();

            var shippingCost = calcService.CalculateCost(order);
            var expectedCost = items * 3.0M;

            Assert.AreEqual(expectedCost, shippingCost);
        }

        [Test]
        public void Service_Should_Calculate_For_Ups_Correctly()
        {
            var items = 2;
            var shippingMethod = ShippingMethod.Ups;

            var order = this._context.CreateOrder(items, shippingMethod);
            var calcService = new SimpleShippingCostCalculatorService();

            var shippingCost = calcService.CalculateCost(order);
            var expectedCost = items * 4.25M;

            Assert.AreEqual(expectedCost, shippingCost);
        }

        [Test]
        public void Service_Should_Calculate_For_Speedy_Correctly()
        {
            var items = 2;
            var shippingMethod = ShippingMethod.Speedy;

            var order = this._context.CreateOrder(items, shippingMethod);
            var calcService = new SimpleShippingCostCalculatorService();

            var shippingCost = calcService.CalculateCost(order);
            var expectedCost = items * 5.0M;

            Assert.AreEqual(expectedCost, shippingCost);
        }

        [Test]
        public void Service_Should_Throw_For__Unsupported_Shipping_Method()
        {
            Assert.Throws<NotSupportedException>(() =>
            {
                var items = 2;
                var shippingMethod = ShippingMethod.Dhl;

                var order = this._context.CreateOrder(items, shippingMethod);
                var calcService = new SimpleShippingCostCalculatorService();

                var shippingCost = calcService.CalculateCost(order);
            });
        }
    }
}