using RSM.Kata.Shared.Interfaces.Products;

namespace RSM.Kata.DTO
{
    public class Video : IProduct
    {
        public int Id { get; set; }
        public string ProductSKU { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
    }
}