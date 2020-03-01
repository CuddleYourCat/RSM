using System.Collections.Generic;

namespace RSM.Kata.Shared.Interfaces.Products
{
    public interface IShoppingCart
    {
        IEnumerable<IProduct> Items { get; set; }
    }
}