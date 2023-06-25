using Order.Domain.Models;
using Order.Domain.Validation.Base;

namespace Order.Domain.Interfaces.Services
{
    public interface IOrderService : IBaseService<OrderModel>
    {
        Task<Response<List<OrderModel>>> ListByFilterAsync(Guid? id = null, Guid? clientId = null, Guid? userId = null);
    }
}
