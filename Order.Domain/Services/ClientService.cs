using Order.Domain.Interfaces.Factory;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Services
{
    public class ClientService : BaseService<ClientModel>, IClientService
    {
        public ClientService(IBaseRepository<ClientModel> repository, IValidationFactory validationFactory) : base(repository, validationFactory)
        {
        }

        public Task<Response<List<ClientModel>>> ListByFilterAsync(Guid? id = null, string? name = null)
        {
            throw new NotImplementedException();
        }
    }
}
