using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IBaseRepository<UserModel>
    {
        Task<List<UserModel>> ListByFilterAsync(Guid? id = null, string? name = null);
    }
}
