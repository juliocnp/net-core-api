namespace Order.Domain.Models
{
    public class UserModel : EntityBase 
    {
        public string Name { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }
}
