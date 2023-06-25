namespace Order.Domain.Models
{
    public class ProductModel : EntityBase
    {
        public string Description { get; set; } = String.Empty;
        public decimal SellValue { get; set; }
        public int Stock { get; set; }
    }
}
