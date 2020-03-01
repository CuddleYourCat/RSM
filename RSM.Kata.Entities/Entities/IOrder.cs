using RSM.Kata.Shared.Interfaces.Persons;
using RSM.Kata.Shared.Interfaces.Products;

namespace RSM.Kata.Core.Entities
{
    public interface IOrder
    {
        IProduct OrderItem { get; set; }

        IPerson Customer { get; set; }

        void ProcessOrder();


    }
}