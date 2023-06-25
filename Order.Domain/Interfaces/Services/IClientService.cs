using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Interfaces.Services
{
    public interface IClientService : IBaseService<ClientModel>
    {
        Task<Response<List<ClientModel>>> ListByFilterAsync(Guid? id = null, string? name = null);
    }
}
