using Data.Entities;
using RSM.Kata.Core.Handlers.Factory;
using RSM.Kata.Shared.Interfaces.Persons;
using RSM.Kata.Shared.Interfaces.Products;

namespace RSM.Kata.Core.Entities
{
    public class Order : IOrder
    {
        public IProduct OrderItem { get; set; }

        public IPerson Customer { get; set; }

        public void ProcessOrder()
        {
            var handler = new OrderProcessorFactory(this).GetOrderHandler();
            handler.ProcessOrder();
        }
    }
}
