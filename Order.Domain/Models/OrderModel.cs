namespace Order.Domain.Models
{
    public class OrderModel: EntityBase
    {
        public ClientModel Client { get; set; } = new ClientModel();
        public UserModel User { get; set; } = new UserModel();
        public List<OrderItemModel> Items { get; set; } = new List<OrderItemModel>();
    }
}
