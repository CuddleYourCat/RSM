using RSM.Kata.Core.Entities;

namespace RSM.Kata.Core.Handlers.Factory
{
    public class OrderProcessorFactory
    {
        private readonly IOrder _order;
        public OrderProcessorFactory(IOrder order)
        {
            _order = order;
        }
        public IOrderHandler GetOrderHandler()
        {
            return new PhysicalProductOrderHandler(_order);
        }

    }
}