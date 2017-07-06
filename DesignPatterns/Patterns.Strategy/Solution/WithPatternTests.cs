using NUnit.Framework;
using Patterns.Strategy.Common;

namespace Patterns.Strategy.Solution
{
    [TestFixture]
    public class WithPatternTests
    {
        private readonly Context _context = new Context();

        [Test]
        public void Service_Should_Return_Correct_Price_For_FedEx()
        {
            var items = 2;
            var shippingMethod = ShippingMethod.FedEx;

            var order = this._context.CreateOrder(items, shippingMethod);
            var calcService = new SmartShippingCostCalculatorService(new FedExCostCalculationStrategy());

            var shippingCost = calcService.CalculateCost(order);
            var expectedCost = items * 3.0M;

            Assert.AreEqual(expectedCost, shippingCost);
        }

        [Test]
        public void Service_Should_Return_Correct_Price_For_Ups()
        {
            var items = 2;
            var shippingMethod = ShippingMethod.Ups;

            var order = this._context.CreateOrder(items, shippingMethod);
            var calcService = new SmartShippingCostCalculatorService(
                new UpsCostCalculationStrategy());

            var shippingCost = calcService.CalculateCost(order);
            var expectedCost = items * 4.25M;

            Assert.AreEqual(expectedCost, shippingCost);
        }

        [Test]
        public void Service_Should_Return_Correct_Price_For_Speedy()
        {
            var items = 2;
            var shippingMethod = ShippingMethod.Speedy;

            var order = this._context.CreateOrder(items, shippingMethod);
            var calcService = new SmartShippingCostCalculatorService(new SpeedyCostCalculationStrategy());

            var shippingCost = calcService.CalculateCost(order);
            var expectedCost = items * 5.0M;

            Assert.AreEqual(expectedCost, shippingCost);
        }

        //[Test]
        //public void This_Test_Does_Not_Even_Compile()
        //{
        //    var items = 2;
        //    var shippingMethod = ShippingMethod.Dhl;

        //    var order = this._context.CreateOrder(items, shippingMethod);
        //    var calcService = new SmartShippingCostCalculatorService(
        //        new DhlCostCalculationStrategy());

        //    var shippingCost = calcService.CalculateCost(order);
        //    var expectedCost = unknown;

        //    Assert.AreEqual(expectedCost, shippingCost);
        //}
    }
}