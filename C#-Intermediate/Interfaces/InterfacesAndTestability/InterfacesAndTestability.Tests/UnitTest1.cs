using System;
using Xunit;

namespace InterfacesAndTestability.Tests
{
    public class UnitTest1
    {
        // MethodName_Condition_Expectation

        [Fact]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            Assert.Throws<InvalidOperationException>(() => { 
                orderProcessor.Process(order);
            });
        }

        [Fact]
        public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.True(order.IsShipped);
            Assert.Equal(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
            Assert.Equal(1, order.Shipment.Cost);
        }

        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 1;
            }
        }
    }
}
