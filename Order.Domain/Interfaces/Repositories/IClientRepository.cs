using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IClientRepository : IBaseRepository<ClientModel>
    {
        Task<List<ClientModel>> ListByFilterAsync(Guid? id = null, string? name = null);
    }
}
