using Order.Domain.Interfaces.Factory;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Services
{
    public class OrderService : BaseService<OrderModel>, IOrderService
    {
        public OrderService(IBaseRepository<OrderModel> repository, IValidationFactory validationFactory) : base(repository, validationFactory)
        {
        }

        public Task<Response<List<OrderModel>>> ListByFilterAsync(Guid? id = null, Guid? clientId = null, Guid? userId = null)
        {
            throw new NotImplementedException();
        }
    }
}
