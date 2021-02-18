namespace Entities.Products
{
    public class Product
    {
        public int Id { get; set; }

        //[Precision(precision: 10, scale: 2)]
        public decimal Price { get; set; }
    }
}

