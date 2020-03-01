namespace RSM.Kata.Shared.Interfaces.Products
{
    public interface IProduct
    {
        int Id { get; set; }

        string ProductSKU { get; set; }
        string Name { get; set; }

        double UnitPrice { get; set; }

    }
}
