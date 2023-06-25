using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Interfaces.Services
{
    public interface IOrderItemService : IBaseService<OrderItemModel>
    {
        Task<Response<List<OrderItemModel>>> ListByFilterAsync(Guid? id = null, Guid? orderId = null);
    }
}
