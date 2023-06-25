using Order.Domain.Interfaces.Factory;
using Order.Domain.Interfaces.Repositories;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Services
{
    public class OrderItemService : BaseService<OrderItemModel>, IOrderItemService
    {
        public OrderItemService(IBaseRepository<OrderItemModel> repository, IValidationFactory validationFactory) : base(repository, validationFactory)
        {
        }

        public Task<Response<List<OrderItemModel>>> ListByFilterAsync(Guid? id = null, Guid? orderId = null)
        {
            throw new NotImplementedException();
        }
    }
}
