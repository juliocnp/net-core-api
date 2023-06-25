namespace Order.Domain.Models
{
    public class OrderItemModel: EntityBase
    {
        public OrderModel Order { get; set; } = new OrderModel();
        public ProductModel Product { get; set; } = new ProductModel();
        public decimal SellValue { get; set; }
        public int Quantity { get; set;}
        public decimal TotalAmount { get; set; }
    }
}
