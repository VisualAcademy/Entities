namespace Entities.CustomerOrderOrderDetails
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public OrderDetails Details { get; set; }
    }
}
