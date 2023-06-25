namespace Order.Domain.Models
{
    public class ClientModel : EntityBase
    {
        public string Name { get; set; } = String.Empty;
        public string Email { get; set; } = String.Empty;
        public string PhoneNumber { get; set; } = String.Empty;
        public string Address { get; set; } = String.Empty;
    }
}
